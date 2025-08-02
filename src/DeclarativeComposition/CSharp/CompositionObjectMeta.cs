using DeclarativeComposition.CodeGen.Interpreters;

namespace DeclarativeComposition.CSharp;

public partial class CompositionObjectMeta : ObjectMeta
{
    public string Alias { get; }
    public string? ContentFieldName { get; }
    
    public CompositionObjectMeta(
        string alias,
        string ns, string typeName, ObjectMeta? baseObjectMeta, ObjectInterpreter interpreter,
        FieldMeta[] fields, string? contentFieldName = null
    ) : base(ns, typeName, baseObjectMeta, interpreter)
    {
        Alias = alias;
        _fields = fields.ToDictionary(
            static f => f.Name,
            static f => f,
            StringComparer.OrdinalIgnoreCase
        );
        ContentFieldName = contentFieldName;
    }

    private readonly Dictionary<string, FieldMeta> _fields;
    
    public bool TryGetField(string name, out FieldMeta field)
    {
        if (_fields.TryGetValue(name, out var foundField))
        {
            field = foundField;
            return true;
        }
        if (BaseObjectMeta is not CompositionObjectMeta baseCom)
        {
            field = null!;
            return false;
        }
        return baseCom.TryGetField(name, out field);
    }
}