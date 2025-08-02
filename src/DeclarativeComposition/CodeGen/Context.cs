namespace DeclarativeComposition.CodeGen;

public record Context
{
    public Context(string namespaceName, string className)
    {
        NamespaceName = namespaceName;
        ClassName = className;
    }

    /// <summary>
    /// The namespace name to use for the generated code.
    /// </summary>
    public string NamespaceName { get; set; }
    
    /// <summary>
    /// The class name to use for the generated code.
    /// </summary>
    public string ClassName { get; set; }
    
    public string FullClassName => $"{NamespaceName}.{ClassName}";

    /// <summary>
    /// Indicates whether the generated code should use an independent initializer for the composition.
    /// </summary>
    public bool IndependentInitializer { get; set; } = false;
    
    private int _anonymousObjectCounter;
    /// <summary>
    /// Counter for anonymous objects.
    /// </summary>
    public int AnonymousObjectCounter => ++_anonymousObjectCounter;
    
    /// <summary>
    /// Declarations of fields for the generated C# class.
    /// </summary>
    public List<string> FieldDeclarations { get; } = new();
    
    /// <summary>
    /// Body of the initializer for the generated C# class.
    /// </summary>
    public List<string> InitializerBody { get; } = new();
}