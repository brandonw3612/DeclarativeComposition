using DeclarativeComposition.Sharp.ObjectProviders;

namespace DeclarativeComposition.Sharp.FieldProviders;

public abstract class SharpFieldProvider(SharpObjectProvider? valueType = null)
{
    public SharpObjectProvider? FieldValueType { get; } = valueType;
    
    public abstract string GenerateSharpCode(string objectName, string value);
}