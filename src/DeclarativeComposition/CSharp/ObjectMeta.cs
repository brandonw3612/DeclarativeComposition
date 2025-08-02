using DeclarativeComposition.CodeGen.Interpreters;
using DeclarativeComposition.DCL.AST;

namespace DeclarativeComposition.CSharp;

public class ObjectMeta
{
    public ObjectMeta(string ns, string typeName, ObjectMeta? baseObjectMeta, ObjectInterpreter interpreter)
    {
        Namespace = ns;
        TypeName = typeName;
        BaseObjectMeta = baseObjectMeta;
        Interpreter = interpreter;
        Interpreter.SetMeta(this);
    }

    /// <summary>
    /// Namespace of the object type.
    /// </summary>
    public string Namespace { get; }
    
    /// <summary>
    /// Name of the object type.
    /// </summary>
    public string TypeName { get; }
    
    /// <summary>
    /// Full name of the object type, including namespace.
    /// </summary>
    public string FullTypeName => $"{Namespace}.{TypeName}";
    
    /// <summary>
    /// Base object metadata for inheritance. Null if and only if this is a root object type.
    /// </summary>
    public ObjectMeta? BaseObjectMeta { get; }

    /// <summary>
    /// Interpreter for this object metadata.
    /// </summary>
    public ObjectInterpreter Interpreter { get; }

    /// <summary>
    /// Checks if this object metadata is derived from the target object metadata.
    /// </summary>
    /// <param name="target">Target object metadata to check against.</param>
    /// <returns>True if this object metadata is assignable to the target, false otherwise.</returns>
    public bool IsAssignableTo(ObjectMeta target) =>
        ReferenceEquals(this, target) ||
        BaseObjectMeta != null && BaseObjectMeta.IsAssignableTo(target);
}