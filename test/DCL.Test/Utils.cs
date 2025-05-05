namespace DCL.Test;

public static class Utils
{
    public static string RemoveBlanks(string input) =>
        string.Join('\n',
                    input.Split('\n')
                         .Select(static line => line.Trim())
                         .Where(static line => line.Length > 0)
        );
}