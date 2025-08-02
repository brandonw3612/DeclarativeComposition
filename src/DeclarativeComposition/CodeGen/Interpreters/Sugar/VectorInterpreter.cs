using System.Text.RegularExpressions;

namespace DeclarativeComposition.CodeGen.Interpreters.Sugar;

public class VectorInterpreter : SugarObjectInterpreter
{
    private static readonly Regex WhitespaceRegex = new(
        @"[,\s]+",
        RegexOptions.Compiled
    );
    
    private int _size;
    private string _typeName;

    public VectorInterpreter(int size, string typeName)
    {
        if (size is < 2 or > 4)
            throw new ArgumentOutOfRangeException(nameof(size), "Vector size must be between 2 and 4.");
        _size = size;
        _typeName = typeName;
    }

    protected override bool CanInterpret(string src)
    {
        try
        {
            var size = ParseFloats(src).Length;
            return size == 1 || size == _size;
        }
        catch
        {
            return false;
        }
    }

    protected override string Interpret(string src)
    {
        var values = ParseFloats(src);
        if (values.Length == 1) values = Enumerable.Repeat(values[0], _size).ToArray();
        var pars = string.Join(", ", values.Select(static v => $"{v}f"));
        return $"new System.Numerics.{_typeName}({pars})";
    }
    
    private static float[] ParseFloats(string input)
    {
        List<float> result = [];

        var parts = WhitespaceRegex.Split(input);

        foreach (var part in parts)
        {
            if (string.IsNullOrWhiteSpace(part)) continue;
            if (!float.TryParse(part, out var value))
                throw new FormatException($"Cannot parse '{part}' as a float.");
            result.Add(value);
        }

        return result.ToArray();
    }
}