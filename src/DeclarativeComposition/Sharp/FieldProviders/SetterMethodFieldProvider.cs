using DeclarativeComposition.Sharp.ObjectProviders;

namespace DeclarativeComposition.Sharp.FieldProviders;

public class SetterMethodFieldProvider(string methodName, SharpObjectProvider? valueType = null)
    : SharpFieldProvider(valueType)
{
    /// <summary>
    /// Name of the method to set the field.
    /// </summary>
    public string MethodName { get; } = methodName;

    public override string GenerateSharpCode(string objectName, string value) => $"{objectName}.{MethodName}({value});";
}