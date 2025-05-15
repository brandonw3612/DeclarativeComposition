using DeclarativeComposition.Sharp.ObjectProviders;

namespace DeclarativeComposition.Sharp.FieldProviders;

public class PropertyFieldProvider(string propertyName, SharpObjectProvider? valueType = null)
    : SharpFieldProvider(valueType)
{
    /// <summary>
    /// Name of the property to set.
    /// </summary>
    public string PropertyName { get; } = propertyName;
    
    public override string GenerateSharpCode(string objectName, string value) => $"{objectName}.{PropertyName} = {value};";
}