using DeclarativeComposition.DCL.AST;

namespace DeclarativeComposition.CodeGen.Interpreters;

public abstract class CompositionFieldInterpreter : FieldInterpreter
{
    public abstract string WrapFieldCode(string objectName, string fieldValue);
    
    public override void Interpret(ExpressionNode value, string objectName, Context context)
    {
        if (value is SharpCodeNode scn)
        {
            context.InitializerBody.Add(WrapFieldCode(objectName, scn.Code));
            return;
        }
        var values = value is CollectionNode col ? col.Items.OfType<ExpressionNode>().ToArray() : [value];
        bool global = true, local;
        foreach (var v in values)
        {
            local = false;
            if (v is SharpCodeNode scnValue)
            {
                context.InitializerBody.Add(WrapFieldCode(objectName, scnValue.Code));
                continue;
            }
            foreach (var om in Meta!.AcceptableObjectMetas)
            {
                if (!om.Interpreter.CanInterpret(v)) continue;
                var interpreted = om.Interpreter.Interpret(v, context);
                context.InitializerBody.Add(WrapFieldCode(objectName, interpreted));
                local = true;
                break;
            }
            if (local is false) global = false;
        }
        if (global is false)
        {
            context.InitializerBody.Add($"// Cannot interpret (part of) property '{Meta.Name}' for object '{objectName}'.");
        }
    }
}

public class PropertyFieldInterpreter : CompositionFieldInterpreter
{
    private readonly string _propertyName;

    public PropertyFieldInterpreter(string propertyName)
    {
        _propertyName = propertyName;
    }

    public override string WrapFieldCode(string objectName, string fieldValue)
    {
        return $"{objectName}.{_propertyName} = {fieldValue};";
    }
}

public class MethodFieldInterpreter : CompositionFieldInterpreter
{
    private readonly string _methodName;

    public MethodFieldInterpreter(string methodName)
    {
        _methodName = methodName;
    }

    public override string WrapFieldCode(string objectName, string fieldValue)
    {
        return $"{objectName}.{_methodName}({fieldValue});";
    }
}