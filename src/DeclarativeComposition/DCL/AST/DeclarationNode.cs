namespace DeclarativeComposition.DCL.AST;

/// <summary>
/// Declaration node of the AST.
/// </summary>
public class DeclarationNode : AstNode
{
    /// <summary>
    /// List of properties in the declaration.
    /// </summary>
    public List<PropertyNode> Properties { get; } = new();
}