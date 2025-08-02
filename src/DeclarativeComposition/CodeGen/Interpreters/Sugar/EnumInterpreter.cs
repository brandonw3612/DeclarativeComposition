namespace DeclarativeComposition.CodeGen.Interpreters.Sugar;

public class EnumInterpreter : SugarObjectInterpreter
{
    private readonly string _namespaceName;
    private readonly string _enumName;
    
    private readonly HashSet<string> _enumValues;

    public EnumInterpreter(string namespaceName, string enumName, string[] enumValues)
    {
        _namespaceName = namespaceName;
        _enumName = enumName;
        _enumValues = new(enumValues, StringComparer.OrdinalIgnoreCase);
    }
    
    protected override bool CanInterpret(string src)
    {
        return _enumValues.Contains(src.Trim());
    }

    protected override string Interpret(string src)
    {
        var value = src.Trim();
        value = _enumValues.Single(v => v.Equals(value, StringComparison.OrdinalIgnoreCase))!;
        return $"{_namespaceName}.{_enumName}.{value}";
    }
}