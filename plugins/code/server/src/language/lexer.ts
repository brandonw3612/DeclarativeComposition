import { LanguageError } from './error';

export enum TokenType {
  Identifier,
  StringLiteral,
  Hash,
  Dot,
  Colon,
  Equal,
  LeftBrace,
  RightBrace,
  EndOfFile,
}

export interface Token {
  type: TokenType;
  text: string;
  start: number;
  end: number;
}

export class Lexer {
  private source: string;
  private pos = 0;

  constructor(source: string) {
    this.source = source;
  }

  public nextToken(): Token {
    this.skipWhitespace();

    if (this.pos >= this.source.length) {
      return this.makeToken(TokenType.EndOfFile, "", this.pos, this.pos);
    }

    const ch = this.source[this.pos];

    switch (ch) {
      case '{': return this.singleChar(TokenType.LeftBrace);
      case '}': return this.singleChar(TokenType.RightBrace);
      case '.': return this.singleChar(TokenType.Dot);
      case ':': return this.singleChar(TokenType.Colon);
      case '=': return this.singleChar(TokenType.Equal);
      case '#': return this.singleChar(TokenType.Hash);
      case '"': return this.scanString();
      default:
        if (this.isAlpha(ch)) { return this.scanIdentifier(); }
        throw this.error(`Unexpected character '${ch}'`);
    }
  }

  public step(): void {
	this.pos++;
  }

  private singleChar(type: TokenType): Token {
    const start = this.pos;
    const text = this.source[start];
    this.pos++;
    return this.makeToken(type, text, start, this.pos);
  }

  private scanIdentifier(): Token {
    const start = this.pos;
    while (this.pos < this.source.length && this.isAlphaNum(this.source[this.pos])) {
      this.pos++;
    }
    const text = this.source.slice(start, this.pos);
    return this.makeToken(TokenType.Identifier, text, start, this.pos);
  }

  private scanString(): Token {
    const start = this.pos;
    this.pos++; // skip opening "

    while (this.pos < this.source.length && this.source[this.pos] !== '"') {
      this.pos++;
    }

    if (this.source[this.pos] !== '"') {
      throw this.error("Unterminated string literal", start);
    }

    this.pos++; // skip closing "
    const text = this.source.slice(start + 1, this.pos - 1);
    return this.makeToken(TokenType.StringLiteral, text, start, this.pos);
  }

  private skipWhitespace() {
    while (this.pos < this.source.length && /\s/.test(this.source[this.pos])) {
      this.pos++;
    }
  }

  private makeToken(type: TokenType, text: string, start: number, end: number): Token {
    return { type, text, start, end };
  }

  private isAlpha(ch: string): boolean {
    return /[a-zA-Z_]/.test(ch);
  }

  private isAlphaNum(ch: string): boolean {
    return /[a-zA-Z0-9_]/.test(ch);
  }

  private error(msg: string, at: number = this.pos): LanguageError {
    return new LanguageError('Lexical', msg, at, at + 1);
  }
}