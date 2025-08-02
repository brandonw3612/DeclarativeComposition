using System.Text.RegularExpressions;

namespace DeclarativeComposition.CodeGen.Interpreters.Sugar;

public class MatrixInterpreter : SugarObjectInterpreter
{
    private static readonly Regex WhitespaceRegex = new(
        @"[,\s]+",
        RegexOptions.Compiled
    );
    
    private int _rowSize, _columnSize;

    public MatrixInterpreter(int rowSize, int columnSize)
    {
        if ((rowSize, columnSize) is not (3, 2) and not (4, 4)) 
            throw new ArgumentException("Matrix size must be either 3x2 or 4x4.");
        _rowSize = rowSize;
        _columnSize = columnSize;
    }

    protected override bool CanInterpret(string src)
    {
        try
        {
            var size = ParseFloats(src).Length;
            return (_rowSize, _columnSize) switch
            {
                (3, 2) => size is 6,
                (4, 4) => size is 16 or 6,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    protected override string Interpret(string src)
    {
        var v = ParseFloats(src);
        var pars = string.Join(", ", v.Select(static f => $"{f}f"));
        return (_rowSize, _columnSize) switch
        {
            (3, 2) => $"new System.Numerics.Matrix3x2({pars})",
            (4, 4) when v.Length == 16 => $"new System.Numerics.Matrix4x4({pars})",
            (4, 4) when v.Length == 6 => $"new System.Numerics.Matrix4x4(new System.Numerics.Matrix3x2({pars}))",
            _ => throw new InvalidOperationException("Unsupported vector size.")
        };
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