namespace DeclarativeComposition.DCL.AST;

/// <summary>
/// String literal node in the AST.
/// </summary>
/// <param name="content">Content of the string literal.</param>
public class StringLiteralNode(string content) : SingleExpressionNode
{
    /// <summary>
    /// Content of the string literal.
    /// </summary>
    public string Content { get; } = content;
}