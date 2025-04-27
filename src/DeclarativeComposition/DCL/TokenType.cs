namespace DeclarativeComposition.DCL;

/// <summary>
/// Type of token in a DCL context.
/// </summary>
public enum TokenType
{
    Identifier,
    StringLiteral,
    LeftBrace, // {
    RightBrace, // }
    Dot, // .
    Equal, // =
    Colon, // :
    Hash, // #
    EndOfFile
}