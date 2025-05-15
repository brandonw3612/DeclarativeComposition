using DeclarativeComposition.Sharp;

namespace DeclarativeComposition.DCL.AST;

public class CollectionNode : ExpressionNode
{
    /// <summary>
    /// Items in the collection.
    /// </summary>
    public List<SingleExpressionNode> Items { get; } = new();

    public string[] Translate(Translator translator)
    {
        List<string> result = new();
        foreach (var item in Items)
        {
            result.Add(item.Translate(translator));
        }
        return result.ToArray();
    }
}