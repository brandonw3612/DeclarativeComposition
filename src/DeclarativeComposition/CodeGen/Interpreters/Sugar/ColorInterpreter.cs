using System.Text.RegularExpressions;

namespace DeclarativeComposition.CodeGen.Interpreters.Sugar;

public class ColorInterpreter : SugarObjectInterpreter
{
    private static readonly HashSet<string> PredefinedColors =
    [
        "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "Black", "BlanchedAlmond",
        "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "CornflowerBlue",
        "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki",
        "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen",
        "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DimGray",
        "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold",
        "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki",
        "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan",
        "LightGoldenrodYellow", "LightGray", "LightGreen", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue",
        "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon",
        "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue",
        "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin",
        "NavajoWhite", "Navy", "OldLace", "Olive", "OliveDrab", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod",
        "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue",
        "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell",
        "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal",
        "Thistle", "Tomato", "Transparent", "Turquoise", "Violet", "Wheat", "White", "WhiteSmoke", "Yellow",
        "YellowGreen"
    ];
    
    private static readonly Regex ColorHexRegex = new(
        "^#?(?:[0-9a-f]{3}|[0-9a-f]{4}|[0-9a-f]{6}|[0-9a-f]{8})$",
        RegexOptions.Compiled | RegexOptions.IgnoreCase
    );

    private static readonly Regex ColorRgbRegex = new(
        @"^\s*rgb\s*\(\s*(\d{1,3})\s*(?:,|\s)\s*(\d{1,3})\s*(?:,|\s)\s*(\d{1,3})\s*\)\s*$",
        RegexOptions.Compiled | RegexOptions.IgnoreCase
    );

    private static readonly Regex ColorRgbaRegex = new(
        @"^\s*rgba\s*\(\s*(\d+)\s*(?:,|\s)\s*(\d+)\s*(?:,|\s)\s*(\d+)\s*(?:,|\s)\s*(\d+\.\d*|\.\d+|\d+)\s*\)\s*$",
        RegexOptions.Compiled | RegexOptions.IgnoreCase);
    
    private static readonly Regex ColorArgbRegex = new(
        @"^\s*argb\s*\(\s*(\d+\.\d*|\.\d+|\d+)\s*(?:,|\s)\s*(\d+)\s*(?:,|\s)\s*(\d+)\s*(?:,|\s)\s*(\d+)\s*\)\s*$",
        RegexOptions.Compiled | RegexOptions.IgnoreCase);
    
    private static readonly Regex ColorRgbaPercentRegex = new(
        @"^\s*rgba\s*\(\s*(\d+)\s*(?:,|\s)\s*(\d+)\s*(?:,|\s)\s*(\d+)\s*(?:,|\s)\s*(\d+\.\d*|\.\d+|\d+)%\s*\)\s*$",
        RegexOptions.Compiled | RegexOptions.IgnoreCase);
    
    private static readonly Regex ColorArgbPercentRegex = new(
        @"^\s*argb\s*\(\s*(\d+\.\d*|\.\d+|\d+)%\s*(?:,|\s)\s*(\d+)\s*(?:,|\s)\s*(\d+)\s*(?:,|\s)\s*(\d+)\s*\)\s*$",
        RegexOptions.Compiled | RegexOptions.IgnoreCase);

    protected override bool CanInterpret(string src) =>
        PredefinedColors.Contains(src.Trim()) ||
        ColorHexRegex.IsMatch(src) ||
        ColorRgbRegex.IsMatch(src) ||
        ColorRgbaRegex.IsMatch(src) ||
        ColorArgbRegex.IsMatch(src) ||
        ColorRgbaPercentRegex.IsMatch(src) ||
        ColorArgbPercentRegex.IsMatch(src);

    protected override string Interpret(string src)
    {
        if (PredefinedColors.Contains(src.Trim()))
        {
            return "Microsoft.UI.Colors." + src.Trim();
        }
        if (ColorHexRegex.IsMatch(src))
        {
            var h = ColorHexRegex.Match(src).Value.TrimStart('#').ToLower();
            string r = "ff", g = "ff", b = "ff", a = "ff";
            switch (h.Length)
            {
                case 3:
                    (r, g, b) = (new(h[0], 2), new(h[1], 2), new(h[2], 2));
                    break;
                case 4:
                    (a, r, g, b) = (new(h[0], 2), new(h[1], 2), new(h[2], 2), new(h[3], 2));
                    break;
                case 6:
                    (r, g, b) = (h.Substring(0, 2), h.Substring(2, 2), h.Substring(4, 2));
                    break;
                case 8:
                    (a, r, g, b) = (h.Substring(0, 2), h.Substring(2, 2), h.Substring(4, 2), h.Substring(6, 2));
                    break;
            }
            return $"Windows.UI.Color.FromArgb(0x{a}, 0x{r}, 0x{g}, 0x{b})";
        }
        if (ColorRgbRegex.IsMatch(src))
        {
            var match = ColorRgbRegex.Match(src);
            return $"Windows.UI.Color.FromArgb(0xff, {match.Groups[1].Value}, {match.Groups[2].Value}, {match.Groups[3].Value})";
        }
        if (ColorRgbaRegex.IsMatch(src))
        {
            var match = ColorRgbaRegex.Match(src);
            return $"Windows.UI.Color.FromArgb({(int)(float.Parse(match.Groups[4].Value) * 255f)}, {match.Groups[1].Value}, {match.Groups[2].Value}, {match.Groups[3].Value})";
        }
        if (ColorArgbRegex.IsMatch(src))
        {
            var match = ColorArgbRegex.Match(src);
            return $"Windows.UI.Color.FromArgb({(int)(float.Parse(match.Groups[1].Value) * 255f)}, {match.Groups[2].Value}, {match.Groups[3].Value}, {match.Groups[4].Value})";
        }
        if (ColorRgbaPercentRegex.IsMatch(src))
        {
            var match = ColorRgbaPercentRegex.Match(src);
            return $"Windows.UI.Color.FromArgb({(int)(float.Parse(match.Groups[4].Value) / 100f * 255f)}, {match.Groups[1].Value}, {match.Groups[2].Value}, {match.Groups[3].Value})";
        }
        if (ColorArgbPercentRegex.IsMatch(src))
        {
            var match = ColorArgbPercentRegex.Match(src);
            return $"Windows.UI.Color.FromArgb({(int)(float.Parse(match.Groups[1].Value) / 100f * 255f)}, {match.Groups[2].Value}, {match.Groups[3].Value}, {match.Groups[4].Value})";
        }
        throw new InvalidOperationException($"Error interpreting color: \"{src}\" is not a valid color.");
    }
}