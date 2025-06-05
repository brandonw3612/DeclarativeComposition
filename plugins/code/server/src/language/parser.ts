import { CollectionNode, DeclarationNode, ExpressionNode, ObjectNode, PropertyNode, RootNode, SharpCodeNode, SingleExpressionNode, StringLiteralNode } from './ast';
import { LanguageError } from './error';
import { Token, TokenType, Lexer } from "./lexer";

export class Parser {
  private lexer: Lexer;
  private current: Token;
  private depth: number;

  constructor(lexer: Lexer) {
    this.lexer = lexer;
    this.current = this.lexer.nextToken();
    this.depth = 0;
  }

  private consume(type: TokenType): void {
    if (this.current.type !== type) {
      throw new LanguageError('Syntax', `Expected ${TokenType[type]}, got ${TokenType[this.current.type]}`, this.current.start, this.current.end);
    }
    this.current = this.lexer.nextToken();
  }

  public parse(): {
    ast: RootNode,
    errors: LanguageError[]
  } {
    const errors: LanguageError[] = [];
    const objects: ObjectNode[] = [];
    while (true) {
      if (this.current.type === TokenType.EndOfFile) {
        break;
      }
      if (this.current.type === TokenType.Identifier) {
        const obj = this.parseObject(errors);
        if (obj) {
          objects.push(obj);
        }
      }
      else {
        errors.push(new LanguageError('Syntax', `Unexpected token "${this.current.text}"`, this.current.start, this.current.end));
        this.synchronize([TokenType.Identifier, TokenType.EndOfFile], errors);
      }
    }
    this.consume(TokenType.EndOfFile);
    const declarations: ObjectNode[] = [];
    for (const obj of objects) {
      if (obj.objectType === 'dc') {
        declarations.push(obj);
      }
    }
    if (declarations.length <= 0) {
      errors.push(new LanguageError('Syntax', `No declaration found. For every DeclarativeComposition source, a declaration is required at the beginning.`, 0, 0));
    } else if (declarations.length > 1) {
      declarations.forEach(decl => {
        errors.push(new LanguageError('Syntax', `Multiple declarations found. Only one declaration is allowed per DeclarativeComposition source.`, decl.start, decl.end));
      });
    } else {
      if (declarations[0].name !== undefined) {
        errors.push(new LanguageError('Syntax', `Declaration name is not allowed.`, declarations[0].start, declarations[0].end));
      }
      if (objects[0].objectType !== 'dc') {
        errors.push(new LanguageError('Syntax', `The declaration must be put at the beginning of the source.`, declarations[0].start, declarations[0].end));
      }
      if (declarations[0].children.length > 0) {
        declarations[0].children.forEach(child => {
          errors.push(new LanguageError('Syntax', `Declaration must not contain nested objects.`, child.start, child.end));
        });
      }
    }
    const normalObjects = objects.filter(obj => obj.objectType !== 'dc');
    return {
      ast: new RootNode(
        0,
        this.current.end,
        normalObjects,
        declarations.length == 1 && objects[0].objectType === 'dc' ? new DeclarationNode(declarations[0].start, declarations[0].end, declarations[0].properties) : undefined
      ),
      errors
    };
  }

  private parseObject(errors: LanguageError[]): ObjectNode | undefined {
    let name: string | undefined = undefined;
    const start = this.current.start;
    const first = this.current;
    try {
      this.consume(TokenType.Identifier);
    } catch (e) {
      if (e instanceof LanguageError) {
        if (e.type === 'Lexical') {
          this.skipInvalidCharacters(errors);
        } else {
          errors.push(new LanguageError('Syntax', `Object identifier expected`, first.start, first.end));
        }
        this.synchronize([TokenType.Colon, TokenType.LeftBrace, TokenType.Identifier, TokenType.Dot], errors);
      }
    }
    let typeName: string;

    if (this.current.type === TokenType.Colon) {
      name = first.text;
      try {
        this.consume(TokenType.Colon);
      } catch {
        this.skipInvalidCharacters(errors);
      }
      typeName = this.current.text;
      try {
        this.consume(TokenType.Identifier);
      } catch (e) {
        if (e instanceof LanguageError) {
          if (e.type === 'Lexical') {
            this.skipInvalidCharacters(errors);
          } else {
            errors.push(new LanguageError('Syntax', `Object type expected`, this.current.start, this.current.end));
          }
          this.synchronize([TokenType.LeftBrace, TokenType.Identifier, TokenType.Dot], errors);
        }
      }
    } else {
      typeName = first.text;
    }

    try {
      this.consume(TokenType.LeftBrace);
    } catch (e) {
      if (e instanceof LanguageError) {
        if (e.type === 'Lexical') {
          this.skipInvalidCharacters(errors);
        } else {
          errors.push(e);
        }
        this.synchronize([TokenType.Identifier, TokenType.Dot], errors);
      }
    }
    const properties: PropertyNode[] = [];
    const children: ObjectNode[] = [];

    this.depth++;

    while (this.current.type === TokenType.Dot || this.current.type === TokenType.Identifier) {
      if (this.current.type === TokenType.Dot) {
        const property = this.parseProperty(errors);
        if (property) {
          properties.push(property);
        }
      } else {
        const child = this.parseObject(errors);
        if (child) {
          children.push(child);
        }
      }
    }

    this.depth--;

    const obj = new ObjectNode(
      start,
      this.current.end,
      typeName,
      properties,
      children,
      name
    );
    try {
      obj.end = this.current.end;
      this.consume(TokenType.RightBrace);
      return obj;
    } catch (e) {
      if (e instanceof LanguageError) {
        if (e.type === 'Lexical') {
          this.skipInvalidCharacters(errors);
        } else {
          errors.push(e);
        }
        this.synchronize([TokenType.Identifier, TokenType.Dot], errors);
      }
      return obj;
    }
  }

  private parseProperty(errors: LanguageError[]): PropertyNode | undefined {
    const start = this.current.start;
    try {
      this.consume(TokenType.Dot);
    } catch (e) {
      if (e instanceof LanguageError) {
        this.skipInvalidCharacters(errors);
      }
    }
    const name = this.current.text;
    try {
      this.consume(TokenType.Identifier);
    } catch (e) {
      if (e instanceof LanguageError) {
        if (e.type === 'Lexical') {
          this.skipInvalidCharacters(errors);
        } else {
          errors.push(e);
          this.synchronize([TokenType.Identifier, TokenType.Dot], errors);
          return undefined;
        }
      }
    }
    try {
      this.consume(TokenType.Equal);
    } catch (e) {
      if (e instanceof LanguageError) {
        if (e.type === 'Lexical') {
          this.skipInvalidCharacters(errors);
        } else {
          errors.push(e);
          this.synchronize([TokenType.Identifier, TokenType.Dot, TokenType.StringLiteral, TokenType.Hash, TokenType.LeftBrace], errors);
        }
      }
    }
    let end = this.current.end;
    const value = this.current.type === TokenType.LeftBrace
      ? this.parseCollection(errors)
      : this.parseSingleExpression(errors);
    if (value) {
      end = value.end;
    }
    return new PropertyNode(start, end, name, value);
  }

  private parseCollection(errors: LanguageError[]): CollectionNode | undefined {
    const start = this.current.start;
    this.consume(TokenType.LeftBrace);
    const items: ExpressionNode[] = [];
    while (this.current.type !== TokenType.RightBrace) {
      const item = this.parseSingleExpression(errors);
      if (item) {
        items.push(item);
      }
    }
    const col = new CollectionNode(start, this.current.end, items);
    try {
      col.end = this.current.end;
      this.consume(TokenType.RightBrace);
      return col;
    } catch (e) {
      if (e instanceof LanguageError) {
        if (e.type === 'Lexical') {
          this.skipInvalidCharacters(errors);
        } else {
          errors.push(e);
        }
        this.synchronize([TokenType.Identifier, TokenType.Dot], errors);
      }
      return col;
    }
  }

  private parseSingleExpression(errors: LanguageError[]): SingleExpressionNode | undefined {
    const start = this.current.start;
    let end = this.current.end;
    switch (this.current.type) {
      case TokenType.StringLiteral: {
        const strVal = this.current.text;
        end = this.current.end;
        try {
          this.consume(TokenType.StringLiteral);
        } catch (e) {
          if (e instanceof LanguageError) {
            this.synchronize([TokenType.Identifier, TokenType.Dot], errors);
          }
        }
        return new StringLiteralNode(start, end, strVal);
      }
      case TokenType.Hash: {
        try {
          this.consume(TokenType.Hash);
        } catch (e) {
          if (e instanceof LanguageError) {
            this.synchronize([TokenType.Identifier, TokenType.Dot], errors);
          }
        }
        const codeVal = this.current.text;
        end = this.current.end;
        try {
          this.consume(TokenType.StringLiteral);
        } catch (e) {
          if (e instanceof LanguageError) {
            if (e.type === 'Lexical') {
              this.skipInvalidCharacters(errors);
            } else {
              errors.push(new LanguageError('Syntax', `Expected string literal after #`, this.current.start, this.current.end));
            }
            this.synchronize([TokenType.Identifier, TokenType.Dot], errors);
          }
        }
        return new SharpCodeNode(start, end, codeVal);
      }
      case TokenType.Identifier:
        return this.parseObject(errors);
      default:
        errors.push(new LanguageError('Syntax', `Unexpected token "${this.current.text}"`, this.current.start, this.current.end));
        return undefined;
    }
  }

  private synchronize(safeTokens: TokenType[], errors: LanguageError[]): void {
    if (this.depth > 0) {
      safeTokens.push(TokenType.RightBrace);
    }
    while (this.current.type !== TokenType.EndOfFile) {
      if (safeTokens.includes(this.current.type)) {
        return;
      }
      try {
        this.current = this.lexer.nextToken();
      } catch (e) {
        errors.push(e as LanguageError);
        this.lexer.step();
      }
    }
  }

  private skipInvalidCharacters(errors: LanguageError[]): void {
    while (this.current.type !== TokenType.EndOfFile) {
      try {
        this.current = this.lexer.nextToken();
        return;
      } catch (e) {
        errors.push(e as LanguageError);
        this.lexer.step();
      }
    }
  }
}