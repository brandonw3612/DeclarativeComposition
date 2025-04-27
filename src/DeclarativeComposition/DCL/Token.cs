namespace DeclarativeComposition.DCL;

/// <summary>
/// Token in a DCL context.
/// </summary>
/// <param name="type">Type of the token.</param>
/// <param name="text">Source text of the token.</param>
/// <param name="line">Line number in the source.</param>
/// <param name="column">>Column number in the source.</param>
public class Token(TokenType type, string text, int line, int column)
{
    /// <summary>
    /// Type of the token.
    /// </summary>
    public TokenType Type { get; } = type;
    
    /// <summary>
    /// Source text of the token.
    /// </summary>
    public string Text { get; } = text;
    
    /// <summary>
    /// Line number in the source.
    /// </summary>
    public int Line { get; } = line;
    
    /// <summary>
    /// Column number in the source.
    /// </summary>
    public int Column { get; } = column;
}