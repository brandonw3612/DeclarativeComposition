namespace DeclarativeComposition.DCL.AST;

public class CollectionNode : ExpressionNode
{
    /// <summary>
    /// Items in the collection.
    /// </summary>
    public List<SingleExpressionNode> Items { get; } = new();
}