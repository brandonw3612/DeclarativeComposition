namespace DeclarativeComposition.DCL.AST;

/// <summary>
/// Property node in the AST.
/// </summary>
/// <param name="name">Name of the property.</param>
/// <param name="value">Value of the property.</param>
public class PropertyNode(string name, ExpressionNode value) : AstNode
{
    /// <summary>
    /// Name of the property.
    /// </summary>
    public string Name { get; } = name;
    
    /// <summary>
    /// Value of the property.
    /// </summary>
    public ExpressionNode Value { get; } = value;
    
    
}