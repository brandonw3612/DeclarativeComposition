using System.Text;

namespace DeclarativeComposition.CodeGen.Interpreters.Sugar;

public class StringInterpreter : SugarObjectInterpreter
{
    protected override bool CanInterpret(string src) => true;

    protected override string Interpret(string src) => Escape(src);
    
    static string Escape(string input)
    {
        var sb = new StringBuilder();
        sb.Append("\"");
        foreach (char c in input)
        {
            switch (c)
            {
                case '\'': sb.Append(@"\'"); break;
                case '\"': sb.Append(@"\"""); break;
                case '\\': sb.Append(@"\\"); break;
                case '\0': sb.Append(@"\0"); break;
                case '\a': sb.Append(@"\a"); break;
                case '\b': sb.Append(@"\b"); break;
                case '\e': sb.Append(@"\e"); break;
                case '\f': sb.Append(@"\f"); break;
                case '\n': sb.Append(@"\n"); break;
                case '\r': sb.Append(@"\r"); break;
                case '\t': sb.Append(@"\t"); break;
                case '\v': sb.Append(@"\v"); break;
                default:
                    sb.Append(c);
                    break;
            }
        }
        sb.Append("\"");
        return sb.ToString();
    }
}