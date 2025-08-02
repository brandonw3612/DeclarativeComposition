namespace DeclarativeComposition.CodeGen.Interpreters.Sugar;

public class BoolInterpreter : SugarObjectInterpreter
{
    protected override bool CanInterpret(string src) => src.ToLowerInvariant() is "true" or "false";

    protected override string Interpret(string src) => src.ToLowerInvariant();
}