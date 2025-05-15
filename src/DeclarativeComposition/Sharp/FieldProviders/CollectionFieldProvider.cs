using DeclarativeComposition.Sharp.ObjectProviders;

namespace DeclarativeComposition.Sharp.FieldProviders;

public class CollectionFieldProvider(string appendMethodName, SharpObjectProvider? valueType = null) 
    : SharpFieldProvider(valueType)
{
    /// <summary>
    /// Name of the method to append to the collection.
    /// </summary>
    public string AppendMethodName { get; } = appendMethodName;

    public override string GenerateSharpCode(string objectName, string value) => $"{objectName}.{AppendMethodName}({value});";
}