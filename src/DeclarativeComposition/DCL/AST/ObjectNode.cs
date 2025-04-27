using DeclarativeComposition.Utils;

namespace DeclarativeComposition.DCL.AST;

/// <summary>
/// Object node in the AST.
/// </summary>
/// <param name="type">Type (alias) of the object.</param>
public class ObjectNode(string type) : ExpressionNode
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
    public string Translate(Sharp.Translator translator)
    {
        var objectProvider = Sharp.ObjectProviders.SharpObjectProvider.FromTypeAlias(Type);
        if (objectProvider is null) return string.Empty;
        var fullClassName = $"{objectProvider.NamespaceName}.{objectProvider.ClassName}";
        if (Name is null && _anonymousId < 0)
        {
            _anonymousId = AnonymousObjectIndexer.Next();
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
                    translator.InitializerBody.Add(
                        pp.SetViaMethod
                            ? $"{localName}.{pp.Accessor}({raw.Code});"
                            : $"{localName}.{pp.Accessor} = {raw.Code};"
                    );
                    break;
                case ObjectNode obj:
                {
                    var objectName = obj.Translate(translator);
                    translator.InitializerBody.Add(
                        pp.SetViaMethod
                            ? $"{localName}.{pp.Accessor}({objectName});"
                            : $"{localName}.{pp.Accessor} = {objectName};"
                    );
                    break;
                }
            }
        }
        if (objectProvider.ChildAppendCall is not null)
        {
            foreach (var childName in Children.Select(child => child.Translate(translator)))
            {
                translator.InitializerBody.Add($"{localName}.{objectProvider.ChildAppendCall}({childName});");
            }
        }
        return localName;
    }
}