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

    /// <summary>
    /// Generates C# partial class code from the AST.
    /// </summary>
    /// <returns>File name and source code for the generated class.</returns>
    public (string fileName, string source) GenerateSharpCode()
    {
        var config = ParseDeclaration();
        Sharp.Translator translator = new(config);
        foreach (var o in Body)
        {
            o.Translate(translator);
        }
        var fileName = $"{config.NamespaceName}.{config.ClassName}.g.cs";
        var source = translator.ToSource();
        return (fileName, source);
    }

    private Sharp.TranslatorConfig ParseDeclaration()
    {
        // Initialize the translator configuration as default.
        Sharp.TranslatorConfig config = new()
        {
            NamespaceName = "DeclarativeComposition.Generated",
            ClassName = "Composition",
            IndependentInitializer = false
        };
        if (Declaration is null) return config;
        // Parse the properties of the declaration.
        foreach (var property in Declaration.Properties)
        {
            var propertyValue = property.Value;
            switch (property.Name.ToLower())
            {
                case "class":
                {
                    var fullClassName = (propertyValue as StringLiteralNode)!.Content;
                    var lastDotIndex = fullClassName.LastIndexOf('.');
                    if (lastDotIndex < 0) 
                    {
                        config.ClassName = fullClassName;
                    }
                    else
                    {
                        config.NamespaceName = fullClassName.Substring(0, lastDotIndex);
                        config.ClassName = fullClassName.Substring(lastDotIndex + 1);
                    }
                    break;
                }
                case "initializer":
                {
                    var initializer = (propertyValue as StringLiteralNode)!.Content.ToLower();
                    config.IndependentInitializer = initializer switch
                    {
                        "independent" => true,
                        "constructor" => false,
                        _ => throw new ArgumentException($"Invalid initializer value: {initializer}")
                    };
                    break;
                }
            }
        }
        return config;
    }
}