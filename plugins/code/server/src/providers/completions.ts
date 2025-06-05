import { CompletionItem, CompletionItemKind, TextDocument } from 'vscode-languageserver-types';
import { DeclarableBuiltins } from '../builtins/builtin';
import { DeclarationBuiltin } from '../builtins/dc';
import { Position, Range, TextEdit } from 'vscode-languageserver-types';
import { RootNode } from '../language/ast';

export const suggestCompletions = (ast: RootNode, document: TextDocument, position: Position): CompletionItem[] => {
	const offset = document.offsetAt(position);
	const completions: CompletionItem[] = [];

	const scope = ast.getScope(offset);

	if (scope.scopeType === 'declaration') {
		DeclarationBuiltin.fields.forEach(field => {
			const linePrefix = document.getText({
				start: { line: position.line, character: 0 },
				end: position
			});
			const col = linePrefix.includes('.') ? linePrefix.lastIndexOf('.') : position.character;
			completions.push({
				label: '.' + field.fieldName,
				kind: CompletionItemKind.Field,
				textEdit: TextEdit.replace(
					Range.create(
						Position.create(position.line, col),
						position
					),
					'.' + field.fieldName + " = "
				),
				detail: field.details || '',
				documentation: field.documentation
			});
		});
		return completions;
	}

	if (scope.scopeType === 'object') {
		const object = scope.provider;
		if (object) {
			const builtin = DeclarableBuiltins[object];
			if (builtin) {
				builtin.fields.forEach(field => {
					const linePrefix = document.getText({
						start: { line: position.line, character: 0 },
						end: position
					});
					const col = linePrefix.includes('.') ? linePrefix.lastIndexOf('.') : position.character;
					completions.push({
						label: '.' + field.fieldName,
						kind: CompletionItemKind.Property,
						textEdit: TextEdit.replace(
							Range.create(
								Position.create(position.line, col),
								position
							),
							"." + field.fieldName + " = "
						),
						detail: field.details || '',
						documentation: field.documentation
					});
				});
			}
		}
	}

	if (scope.scopeType === 'root' || scope.scopeType == 'object') {
		Object.values(DeclarableBuiltins).forEach(builtin => {
			completions.push({
				label: builtin.typeName,
				kind: CompletionItemKind.Class,
				documentation: builtin.documentation,
			});
		});
	}

	return completions;
};