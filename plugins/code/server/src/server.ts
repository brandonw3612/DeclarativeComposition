import {
	createConnection,
	TextDocuments,
	ProposedFeatures,
	CompletionItem,
	CompletionItemKind,
	InitializeParams,
	TextDocumentPositionParams,
	InitializeResult,
	TextDocumentSyncKind,
	Diagnostic,
	DiagnosticSeverity,
	Hover,
} from 'vscode-languageserver/node';

import {
	TextDocument
} from 'vscode-languageserver-textdocument';
import { Lexer } from './language/lexer';
import { Parser } from './language/parser';
import { suggestCompletions } from './providers/completions';
import { onHover } from './providers/hover';

const connection = createConnection(ProposedFeatures.all);
const documents = new TextDocuments<TextDocument>(TextDocument);

connection.onInitialize((_params: InitializeParams): InitializeResult => {
	return {
		capabilities: {
			textDocumentSync: TextDocumentSyncKind.Full,
			hoverProvider: true,
			completionProvider: {
				resolveProvider: true,
				triggerCharacters: ['.', ':', '\n']
			}
		}
	};
});

documents.onDidChangeContent(change => {
	const text = change.document.getText();
	const diagnostics: Diagnostic[] = [];
	const lexer = new Lexer(text);
	const parser = new Parser(lexer);
	const result = parser.parse(); // assume no return value yet
	for (const error of result.errors) {
		const diagnostic: Diagnostic = {
			severity: DiagnosticSeverity.Error,
			range: {
				start: change.document.positionAt(error.start),
				end: change.document.positionAt(error.end)
			},
			message: error.message,
			source: 'parser'
		};
		diagnostics.push(diagnostic);
	}
	connection.sendDiagnostics({ uri: change.document.uri, diagnostics });
});

connection.onHover((textDocumentPosition: TextDocumentPositionParams): Hover | null => {
	const document = documents.get(textDocumentPosition.textDocument.uri);
	if (!document) {
		return null;
	}
	const text = document.getText();
	const position = document.offsetAt(textDocumentPosition.position);
	const contents = onHover(text, position);
	return contents ? { contents } : null;
});

connection.onCompletion((textDocumentPosition: TextDocumentPositionParams): CompletionItem[] => {
	const document = documents.get(textDocumentPosition.textDocument.uri);
	if (!document) {
		return [];
	}
	const text = document.getText();
	const lexer = new Lexer(text);
	const parser = new Parser(lexer);
	const result = parser.parse();
	const ast = result.ast;
	const position = textDocumentPosition.position;
	const completions = suggestCompletions(ast, document, position);
	return completions;
});

connection.onCompletionResolve((item: CompletionItem): CompletionItem => {
	if (item.kind === CompletionItemKind.Text) {
		item.detail = 'Text completion';
		item.documentation = 'This is a text completion item.';
	}
	return item;
});

documents.listen(connection);
connection.listen();