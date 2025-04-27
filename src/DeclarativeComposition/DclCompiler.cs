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
            
            var (fileName, sharpSource) = ast.GenerateSharpCode();
            c.AddSource(fileName, sharpSource);
        });
    }
}