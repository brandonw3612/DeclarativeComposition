using DeclarativeComposition.Sharp;

namespace DeclarativeComposition.DCL.AST;

/// <summary>
/// C# code injection in a DCL context.
/// </summary>
/// <param name="code">Raw C# code to be injected.</param>
public class SharpCodeNode(string code) : SingleExpressionNode
{
    /// <summary>
    /// Raw C# code to be injected in a DCL context.
    /// </summary>
    public string Code { get; } = code;

    public override string Translate(Translator translator) => Code;
}