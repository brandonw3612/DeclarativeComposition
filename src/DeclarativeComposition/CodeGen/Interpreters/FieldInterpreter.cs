using DeclarativeComposition.CSharp;
using DeclarativeComposition.DCL.AST;

namespace DeclarativeComposition.CodeGen.Interpreters;

public abstract class FieldInterpreter
{
    protected FieldMeta? Meta;
    
    public abstract void Interpret(ExpressionNode value, string objectName, Context context);

    public void SetMeta(FieldMeta meta)
    {
        Meta = meta;
    }
}