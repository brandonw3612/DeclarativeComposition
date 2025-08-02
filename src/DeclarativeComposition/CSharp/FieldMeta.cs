using DeclarativeComposition.CodeGen.Interpreters;

namespace DeclarativeComposition.CSharp;

public class FieldMeta
{
    public FieldMeta(string name, string[] acceptableObjectMetas, FieldInterpreter interpreter)
    {
        Name = name;
        _acceptableObjectMetas = acceptableObjectMetas;
        Interpreter = interpreter;
        Interpreter.SetMeta(this);
    }

    public string Name { get; }
    
    private readonly string[] _acceptableObjectMetas;

    public ObjectMeta[] AcceptableObjectMetas => _acceptableObjectMetas
        .Select(static n => MetaLibrary.Current.AllObjectMetas[n])
        .ToArray();
    
    public FieldInterpreter Interpreter { get; }
}