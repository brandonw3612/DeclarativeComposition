namespace DeclarativeComposition.DCL;

/// <summary>
/// AST Parser for Declarative Composition Language.
/// </summary>
public class Parser
{
    private readonly Lexer _lexer;
        private Token _current;

        public Parser(Lexer lexer)
        {
            _lexer = lexer;
            _current = _lexer.NextToken();
        }

        private void Consume(TokenType type)
        {
            if (_current.Type != type)
                throw new Exception($"Error at {_current.Line}:{_current.Column} - Expected {type}, got {_current.Type}");
            _current = _lexer.NextToken();
        }

        public AST.RootNode Parse()
        {
            AST.RootNode dc = new();

            if (_current is {Type: TokenType.Identifier, Text: "dc"})
                dc.Declaration = ParseDeclaration();

            while (_current.Type == TokenType.Identifier)
                dc.Body.Add(ParseObject());

            Consume(TokenType.EndOfFile);
            return dc;
        }

        private AST.DeclarationNode ParseDeclaration()
        {
            Consume(TokenType.Identifier); // 'dc'
            Consume(TokenType.LeftBrace);

            AST.DeclarationNode declaration = new();
            while (_current.Type == TokenType.Dot)
            {
                declaration.Properties.Add(ParseProperty());
            }

            Consume(TokenType.RightBrace);
            
            return declaration;
        }

        private AST.PropertyNode ParseProperty()
        {
            Consume(TokenType.Dot);
            var name = _current.Text;
            Consume(TokenType.Identifier);
            Consume(TokenType.Equal);
            AST.ExpressionNode expr = _current.Type == TokenType.LeftBrace ? ParseCollection() : ParseSingleExpression();
            return new AST.PropertyNode(name, expr);
        }

        private AST.ObjectNode ParseObject()
        {
            string? name = null;
            string typeName;

            var first = _current;
            Consume(TokenType.Identifier);

            if (_current.Type == TokenType.Colon)
            {
                name = first.Text;
                Consume(TokenType.Colon);
                typeName = _current.Text;
                Consume(TokenType.Identifier);
            }
            else
            {
                typeName = first.Text;
            }

            Consume(TokenType.LeftBrace);

            AST.ObjectNode obj = new(typeName)
            {
                Name = name
            };

            while (_current.Type is TokenType.Dot or TokenType.Identifier)
            {
                if (_current.Type == TokenType.Dot)
                    obj.Properties.Add(ParseProperty());
                else
                    obj.Children.Add(ParseObject());
            }

            Consume(TokenType.RightBrace);
            return obj;
        }

        private AST.CollectionNode ParseCollection()
        {
            Consume(TokenType.LeftBrace);
            var collection = new AST.CollectionNode();

            while (_current.Type != TokenType.RightBrace)
            {
                var expr = ParseSingleExpression();
                collection.Items.Add(expr);
            }

            Consume(TokenType.RightBrace);
            return collection;
        }
        
        private AST.SingleExpressionNode ParseSingleExpression()
        {
            switch (_current.Type)
            {
                case TokenType.StringLiteral:
                {
                    var value = _current.Text;
                    Consume(TokenType.StringLiteral);
                    return new AST.StringLiteralNode(value);
                }
                case TokenType.Hash:
                {
                    Consume(TokenType.Hash);
                    var value = _current.Text;
                    Consume(TokenType.StringLiteral);
                    return new AST.SharpCodeNode(value);
                }
                case TokenType.Identifier:
                {
                    return ParseObject();
                }
                default:
                    throw new Exception($"Invalid expression at {_current.Line}:{_current.Column}");
            }
        }
}