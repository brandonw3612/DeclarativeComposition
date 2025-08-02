namespace DeclarativeComposition.DCL.AST;

/// <summary>
/// Root node in the AST for Declarative Composition Language.
/// </summary>
public class RootNode : AstNode
{
    /// <summary>
    /// Declaration of the composition.
    /// </summary>
    public DeclarationNode? Declaration { get; set; }
    
    /// <summary>
    /// Body of the composition.
    /// </summary>
    public List<ObjectNode> Body { get; } = new();
}