using System.Globalization;

namespace DeclarativeComposition.CodeGen.Interpreters.Sugar;

public class NumberInterpreter : SugarObjectInterpreter
{
    public enum NumberType
    {
        Integer,
        Single,
        Double
    }
    
    private readonly NumberType _numberType;
    
    public NumberInterpreter(NumberType numberType)
    {
        _numberType = numberType;
    }

    protected override bool CanInterpret(string src) =>
        _numberType switch
        {
            NumberType.Integer => int.TryParse(src, out _),
            NumberType.Single => float.TryParse(src, out _),
            NumberType.Double => double.TryParse(src, out _),
            _ => false
        };

    protected override string Interpret(string src) =>
        _numberType switch
        {
            NumberType.Integer => int.Parse(src).ToString(),
            NumberType.Single => float.Parse(src).ToString(CultureInfo.InvariantCulture) + "f",
            NumberType.Double => double.Parse(src).ToString(CultureInfo.InvariantCulture),
            _ => throw new InvalidOperationException($"Unsupported number type: {_numberType}")
        };
}