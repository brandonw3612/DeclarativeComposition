using DeclarativeComposition.CSharp;
using DeclarativeComposition.DCL.AST;

namespace DeclarativeComposition.CodeGen.Interpreters;

public class ObjectInterpreter
{
    protected ObjectMeta? Meta;

    public virtual bool CanInterpret(ExpressionNode value) => value switch
    {
        // Raw C# code node
        SharpCodeNode => true,
        // Object node. We verify whether the declared type is supported.
        ObjectNode on => MetaLibrary.Current.DeclarableCOMs.TryGetValue(on.Type, out _),
        _ => false
    };

    public virtual string Interpret(ExpressionNode value, Context context)
    {
        if (value is SharpCodeNode scn)
        {
            return scn.Code;
        }
        if (value is ObjectNode on)
        {
            if (!MetaLibrary.Current.DeclarableCOMs.TryGetValue(on.Type, out var meta))
            {
                throw new InvalidOperationException($"Declaration of object type '{on.Type}' is not supported.");
            }
            return meta.Interpreter.Interpret(on, context);
        }
        throw new InvalidOperationException($"Cannot interpret value of type '{value.GetType().Name}'.");
    }
    
    internal void SetMeta(ObjectMeta meta)
    {
        Meta = meta;
    }
}