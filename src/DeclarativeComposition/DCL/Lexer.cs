using System;
using System.Text;

namespace DeclarativeComposition.DCL;

/// <summary>
/// Lexer (Tokenizer) for Declarative Composition Language.
/// </summary>
public class Lexer
{
    private readonly string _input;
    private int _position;
    private int _line = 1;
    private int _column = 1;

    /// <summary>
    /// Initializes a new instance of the <see cref="Lexer"/> class.
    /// </summary>
    /// <param name="source">The source code to tokenize.</param>
    public Lexer(string source)
    {
        _input = source;
    }

    /// <summary>
    /// Gets the next token from the input.
    /// </summary>
    /// <returns>The next token.</returns>
    /// <exception cref="Exception">Thrown when an unexpected character is encountered.</exception>
    public Token NextToken()
    {
        SkipWhitespaceAndComments();

        if (_position >= _input.Length)
            return new Token(TokenType.EndOfFile, "", _line, _column);

        char current = _input[_position];
        int tokenLine = _line;
        int tokenColumn = _column;

        if (char.IsLetter(current) || current == '_')
            return ReadIdentifier(tokenLine, tokenColumn);
        return current switch
        {
            '"' => ReadStringLiteral(tokenLine, tokenColumn),
            '{' => SingleChar(TokenType.LeftBrace, tokenLine, tokenColumn),
            '}' => SingleChar(TokenType.RightBrace, tokenLine, tokenColumn),
            '.' => SingleChar(TokenType.Dot, tokenLine, tokenColumn),
            '=' => SingleChar(TokenType.Equal, tokenLine, tokenColumn),
            ':' => SingleChar(TokenType.Colon, tokenLine, tokenColumn),
            '#' => SingleChar(TokenType.Hash, tokenLine, tokenColumn),
            _ => throw new Exception($"Unexpected character: {current} at line {tokenLine}, column {tokenColumn}")
        };
    }

    private void SkipWhitespaceAndComments()
    {
        while (_position < _input.Length)
        {
            if (_input[_position] == '\n')
            {
                _position++;
                _line++;
                _column = 1;
            }
            else if (char.IsWhiteSpace(_input[_position]))
            {
                _position++;
                _column++;
            }
            else if (_input[_position] == '/' && _position + 1 < _input.Length && _input[_position + 1] == '/')
            {
                _position += 2;
                _column += 2;
                while (_position < _input.Length && _input[_position] != '\n')
                {
                    _position++;
                    _column++;
                }
            }
            else
                break;
        }
    }

    private Token ReadIdentifier(int line, int column)
    {
        int start = _position;
        while (_position < _input.Length && (char.IsLetterOrDigit(_input[_position]) || _input[_position] == '_'))
        {
            _position++;
            _column++;
        }
        return new Token(TokenType.Identifier, _input.Substring(start, _position - start), line, column);
    }

    private Token ReadStringLiteral(int line, int column)
    {
        int start = _position;
        _position++;
        _column++;
        StringBuilder sb = new StringBuilder();

        while (_position < _input.Length)
        {
            if (_input[_position] == '\\')
            {
                _position++;
                _column++;
                if (_position >= _input.Length)
                    break;
                char escaped = _input[_position++];
                _column++;
                switch (escaped)
                {
                    case '"': sb.Append('"'); break;
                    case '\\': sb.Append('\\'); break;
                    case '/': sb.Append('/'); break;
                    case 'b': sb.Append('\b'); break;
                    case 'f': sb.Append('\f'); break;
                    case 'n': sb.Append('\n'); break;
                    case 'r': sb.Append('\r'); break;
                    case 't': sb.Append('\t'); break;
                    case 'u':
                        string hex = _input.Substring(_position, 4);
                        sb.Append((char)Convert.ToInt32(hex, 16));
                        _position += 4;
                        _column += 4;
                        break;
                    default: throw new Exception($"Invalid escape sequence: \\{escaped} at {line}:{column}");
                }
            }
            else if (_input[_position] == '"')
            {
                _position++;
                _column++;
                break;
            }
            else
            {
                sb.Append(_input[_position++]);
                _column++;
            }
        }

        return new Token(TokenType.StringLiteral, sb.ToString(), line, column);
    }

    private Token SingleChar(TokenType type, int line, int column)
    {
        _position++;
        _column++;
        return new Token(type, "", line, column);
    }
}