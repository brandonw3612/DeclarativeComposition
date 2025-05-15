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
    
    /// <summary>
    /// Translates the object node into C# code.
    /// </summary>
    /// <param name="translator">Translator instance for generating C# code.</param>
    /// <returns>Local name of the object in the generated C# code.</returns>
    public override string Translate(Sharp.Translator translator)
    {
        var objectProvider = Sharp.ObjectProviders.SharpObjectProvider.FromTypeAlias(Type);
        if (objectProvider?.ConstructorCall is null)
        {
            translator.InitializerBody.Add($"// Unable to create an object with type '{Type}': No constructor or factory method found.");
            return "null";
        }
        var fullClassName = $"{objectProvider.NamespaceName}.{objectProvider.ClassName}";
        if (Name is null && _anonymousId < 0)
        {
            _anonymousId = translator.AnonymousObjectCounter;
        }
        var localName = Name ?? $"obj{_anonymousId}";
        if (Name is null) translator.InitializerBody.Add($"var {localName} = {objectProvider.ConstructorCall};");
        else
        {
            var nullable = translator.Config.IndependentInitializer ? "?" : string.Empty;
            translator.VariableDeclarations.Add(Name[0] switch
            {
                >= 'A' and <= 'Z' => $"public {fullClassName}{nullable} {Name};",
                _ => $"private {fullClassName}{nullable} {Name};"
            });
            translator.InitializerBody.Add($"{localName} = {objectProvider.ConstructorCall};");
        }
        foreach (var p in Properties)
        {
            if (!objectProvider.Properties.TryGetValue(p.Name.ToLower(), out var pp)) continue;
            switch (p.Value)
            {
                case SharpCodeNode raw:
                    translator.InitializerBody.Add(pp.GenerateSharpCode(localName, raw.Code));
                    break;
                case ObjectNode obj:
                {
                    var objectName = obj.Translate(translator);
                    translator.InitializerBody.Add(pp.GenerateSharpCode(localName, objectName));
                    break;
                }
                case CollectionNode col:
                {
                    foreach (var item in col.Translate(translator))
                    {
                        translator.InitializerBody.Add(pp.GenerateSharpCode(localName, item));
                    }
                    break;
                }
            }
        }
        if (objectProvider.DefaultChildrenFieldName is not null)
        {
            var childField = objectProvider.Properties[objectProvider.DefaultChildrenFieldName];
            foreach (var childName in Children.Select(child => child.Translate(translator)))
            {
                translator.InitializerBody.Add(childField.GenerateSharpCode(localName, childName));
            }
        }
        return localName;
    }
}