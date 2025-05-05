using DeclarativeComposition.DCL;
using DeclarativeComposition.DCL.AST;

namespace DCL.Test.Primitives;

public abstract class TestBase(string sourcePrefix)
{
    private readonly string _dclSource = File.ReadAllText($"{sourcePrefix}.dc");
    private readonly string _sharpTarget = File.ReadAllText($"{sourcePrefix}.out.cs");

    private Lexer? _lexer;
    private Parser? _parser;
    private RootNode? _root;

    protected abstract void VerifyAst(RootNode root);
    
    [Fact(DisplayName = "Lexical Analysis")]
    public void LexicalAnalysisTest()
    {
        _lexer = new Lexer(_dclSource);
    }
    
    [Fact(DisplayName = "AST Parsing")]
    public void LanguageParsingTest()
    {
        _lexer ??= new Lexer(_dclSource);
        _parser = new Parser(_lexer);
        _root = _parser.Parse();
    }

    [Fact(DisplayName = "AST Evaluation")]
    public void AstTest()
    {
        _lexer ??= new Lexer(_dclSource);
        _parser ??= new Parser(_lexer);
        _root ??= _parser.Parse();
        VerifyAst(_root);
    }
    
    [Fact(DisplayName = "C# Code Generation")]
    public void CodeGenerationTest()
    {
        _lexer ??= new Lexer(_dclSource);
        _parser ??= new Parser(_lexer);
        _root ??= _parser.Parse();
        var (_, sharpCode) = _root.GenerateSharpCode();
        Assert.Equal(Utils.RemoveBlanks(_sharpTarget), Utils.RemoveBlanks(sharpCode));
    }
}