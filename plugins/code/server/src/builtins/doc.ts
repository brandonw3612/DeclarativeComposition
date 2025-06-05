import { MarkupContent } from 'vscode-languageserver';

export class DocBuilder {
	private content: string;

	constructor() {
		this.content = '';
	}

	code(code: string): this {
		this.content += `\`${code}\n\``;
		return this;
	}

	codeBlock(code: string, language = 'plaintext'): this {
		this.content += `\`\`\`${language}\n${code}\n\`\`\``;
		return this;
	}

	text(text: string): this {
		this.content += text;
		return this;
	}

	break(): this {
		this.content += '\n\n';
		return this;
	}

	build(): MarkupContent {
		return {
			kind: 'markdown',
			value: this.content
		};
	}
}

export const msLearn = (url: string): string => {
	return "More on [Microsoft Learn](https://learn.microsoft.com/windows/windows-app-sdk/api/winrt/" + url + ")";
};