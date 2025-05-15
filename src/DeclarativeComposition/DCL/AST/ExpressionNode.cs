namespace DeclarativeComposition.DCL.AST;

/// <summary>
/// Expression node in the AST.
/// </summary>
public abstract class ExpressionNode : AstNode;

public abstract class SingleExpressionNode : ExpressionNode
{
    public abstract string Translate(Sharp.Translator translator);
}