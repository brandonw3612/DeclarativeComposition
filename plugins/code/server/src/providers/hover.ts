import { MarkupContent } from 'vscode-languageserver';
import { BuiltinObjects } from '../builtins/builtin';
import { Lexer } from '../language/lexer';
import { Parser } from '../language/parser';
import { DocBuilder } from '../builtins/doc';

export const onHover = (text: string, position: number): MarkupContent | null => {
		const lexer = new Lexer(text);
		const parser = new Parser(lexer);
		const result = parser.parse();
		const ast = result.ast;
		const scope = ast.getScope(position);
		if (scope) {
			if (scope.scopeType === 'declaration' || scope.scopeType === 'object') {
				const builtin = BuiltinObjects[scope.provider!];
				if (!builtin) {
					return new DocBuilder().text(`${scope.scopeType} ${scope.provider}`).build();
				}
				return builtin.documentation;
			}
			if (scope.scopeType === 'property') {
				const providerObject = scope.provider?.split('/')[0];
				const providerField = scope.provider?.split('/')[1];
				if (providerObject && providerField) {
					const builtin = BuiltinObjects[providerObject];
					if (builtin) {
						const field = builtin.fields.find(f => f.fieldName === providerField);
						if (field) {
							return field.documentation;
						}
					}
				}
				return new DocBuilder().text(`${scope.scopeType}: ${scope.provider}`).build();
			}
			if (scope.scopeType === 'string') {
				return new DocBuilder().text('String literal').break().text(`${scope.provider}`).build();
			}
			if (scope.scopeType === 'sharp') {
				return new DocBuilder().text('C# code snippet').break().codeBlock(`${scope.provider}`, 'csharp').build();
			}
			return new DocBuilder().text(`${scope.scopeType}: ${scope.provider}`).build();
		}
		return null;
};