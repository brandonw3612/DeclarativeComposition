using DeclarativeComposition.CSharp;
using DeclarativeComposition.DCL.AST;

namespace DeclarativeComposition.CodeGen.Interpreters;

public class CompositionObjectInterpreter : ObjectInterpreter
{
    private string _constructorMethodName;

    public CompositionObjectInterpreter(string constructorMethodName)
    {
        _constructorMethodName = constructorMethodName;
    }

    public override bool CanInterpret(ExpressionNode value) =>
        value is ObjectNode ov &&
        Meta is CompositionObjectMeta com &&
        MetaLibrary.Current.DeclarableCOMs.TryGetValue(ov.Type, out var meta) &&
        meta.IsAssignableTo(com);

    public override string Interpret(ExpressionNode value, Context context)
    {
        if (value is not ObjectNode oValue ||
            Meta is not CompositionObjectMeta com ||
            !MetaLibrary.Current.DeclarableCOMs.TryGetValue(oValue.Type, out var meta) ||
            !meta.IsAssignableTo(com))
            throw new InvalidOperationException($"Cannot interpret {value.GetType().Name} as {Meta!.FullTypeName}");
        if (!ReferenceEquals(meta, com)) return meta.Interpreter.Interpret(value, context);
        var localName = oValue.Name ?? $"obj{context.AnonymousObjectCounter}";
        if (oValue.Name is null)
            context.InitializerBody.Add($"var {localName} = _compositor.{_constructorMethodName}();");
        else
        {
            var nullable = context.IndependentInitializer ? "?" : string.Empty;
            context.FieldDeclarations.Add(oValue.Name[0] switch
            {
                >= 'A' and <= 'Z' => $"public {com.FullTypeName}{nullable} {localName};",
                _ => $"private {com.FullTypeName}{nullable} {localName};"
            });
            context.InitializerBody.Add($"{localName} = _compositor.{_constructorMethodName}();");
        }
        
        foreach (var field in oValue.Properties)
        {
            if (com.TryGetField(field.Name, out var fieldMeta))
            {
                fieldMeta.Interpreter.Interpret(field.Value, localName, context);
            }
            else
            {
                context.InitializerBody.Add($"// Cannot match property named '{field.Name}' for '{localName}'.");
            }
        }

        if (com.ContentFieldName is { } cfn && com.TryGetField(cfn, out var contentField))
        {
            foreach (var child in oValue.Children)
            {
                contentField.Interpreter.Interpret(child, localName, context);
            }
        }
        
        return localName;
    }
}