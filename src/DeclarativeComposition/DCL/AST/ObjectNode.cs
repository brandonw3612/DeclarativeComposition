namespace DeclarativeComposition.DCL.AST;

/// <summary>
/// Object node in the AST.
/// </summary>
/// <param name="type">Type (alias) of the object.</param>
public class ObjectNode(string type) : SingleExpressionNode
{
    /// <summary>
    /// Anonymous ID for the object node when it is not a named object.
    /// </summary>
    private int _anonymousId = -1;
    
    /// <summary>
    /// Name of the object.
    /// </summary>
    /// <remarks>
    /// Assigning a name to an object node leads to a field being created in the generated C# class.
    /// </remarks>
    public string? Name { get; set; }
    
    /// <summary>
    /// Type (alias) of the object.
    /// </summary>
    public string Type { get; } = type;
    
    /// <summary>
    /// Properties of the object.
    /// </summary>
    public List<PropertyNode> Properties { get; } = new();
    
    /// <summary>
    /// Children of the object.
    /// </summary>
    public List<ObjectNode> Children { get; } = new();
}