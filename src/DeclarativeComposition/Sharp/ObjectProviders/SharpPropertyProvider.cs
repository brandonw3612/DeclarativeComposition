namespace DeclarativeComposition.Sharp.ObjectProviders;

/// <summary>
/// Property provider for C# objects.
/// </summary>
public class SharpPropertyProvider
{
    /// <summary>
    /// Indicates if the property is set via a method.
    /// </summary>
    public bool SetViaMethod { get; }
    
    /// <summary>
    /// Accessor for the property. Either a property name or a method name.
    /// </summary>
    public string Accessor { get; }
    
    /// <summary>
    /// List of acceptable object providers for this property.
    /// </summary>
    public List<SharpObjectProvider> AcceptableObjectProviders { get; }
    
    /// <summary>
    /// Constructor for the SharpPropertyProvider. By default, the property can be set via the property field.
    /// </summary>
    /// <param name="accessor">Accessor for the property.</param>
    public SharpPropertyProvider(string accessor)
        : this(false, accessor, new List<SharpObjectProvider>())
    {
    }

    /// <summary>
    /// Constructor for the SharpPropertyProvider.
    /// </summary>
    /// <param name="setViaMethod">Indicates if the property is set via a method.</param>
    /// <param name="accessor">Accessor for the property.</param>
    public SharpPropertyProvider(bool setViaMethod, string accessor)
        : this(setViaMethod, accessor, new List<SharpObjectProvider>())
    {
    }
    
    /// <summary>
    /// Constructor for the SharpPropertyProvider with a list of acceptable object providers.
    /// </summary>
    /// <param name="setViaMethod">Indicates if the property is set via a method.</param>
    /// <param name="accessor">>Accessor for the property.</param>
    /// <param name="acceptableObjectProviders">List of acceptable object providers for this property.</param>
    public SharpPropertyProvider(bool setViaMethod, string accessor, List<SharpObjectProvider> acceptableObjectProviders)
    {
        SetViaMethod = setViaMethod;
        Accessor = accessor;
        AcceptableObjectProviders = acceptableObjectProviders;
    }
}