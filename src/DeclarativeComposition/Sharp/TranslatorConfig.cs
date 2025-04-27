namespace DeclarativeComposition.Sharp;

/// <summary>
/// Configuration for the translator.
/// </summary>
public class TranslatorConfig
{
    /// <summary>
    /// The namespace name to use for the generated code.
    /// </summary>
    public string? NamespaceName { get; set; }
    
    /// <summary>
    /// The class name to use for the generated code.
    /// </summary>
    public string? ClassName { get; set; }
    
    /// <summary>
    /// Indicates whether the generated code should use an independent initializer for the composition.
    /// </summary>
    public bool IndependentInitializer { get; set; }
}