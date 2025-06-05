export class LanguageError {
	constructor(
		public type: 'Lexical' | 'Syntax',
		public message: string,
		public start: number,
		public end: number,
	) { }
}