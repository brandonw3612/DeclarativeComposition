using DeclarativeComposition.CodeGen;
using Microsoft.CodeAnalysis;

namespace DeclarativeComposition;

[Generator]
public class DclCompiler : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var files = context.AdditionalTextsProvider.Where(static f => f.Path.EndsWith(".dc"));
        
        context.RegisterSourceOutput(files, (c, text) =>
        {
            var source = text.GetText(CancellationToken.None)?.ToString() ?? "";
            if (string.IsNullOrWhiteSpace(source)) return;
            DCL.Lexer lexer = new(source);
            DCL.Parser parser = new(lexer);
            var ast = parser.Parse();
            
            var (fileName, sharpSource) = CodeGenerator.GenerateSharpSource(ast);
            c.AddSource(fileName, sharpSource);
        });
    }
}