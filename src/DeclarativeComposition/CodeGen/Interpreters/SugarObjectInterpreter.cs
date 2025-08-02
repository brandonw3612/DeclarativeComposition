using DeclarativeComposition.DCL.AST;

namespace DeclarativeComposition.CodeGen.Interpreters;

public abstract class SugarObjectInterpreter : ObjectInterpreter
{
    protected abstract bool CanInterpret(string src);
    protected abstract string Interpret(string src);

    public override bool CanInterpret(ExpressionNode value) =>
        value is StringLiteralNode sln && CanInterpret(sln.Content);

    public override string Interpret(ExpressionNode value, Context context) =>
        Interpret((value as StringLiteralNode)!.Content);
}