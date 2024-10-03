using System.Text.RegularExpressions;

namespace Fresh;

internal static partial class EscapeConstants
{
    internal const string ANSIStart = "\x1b[";
    internal const string ANSIGraphicsFunction = "m";

    private static Regex FilterAnsiEscapes = AnsiFilterGeneratedRegex();

    [GeneratedRegex(@"\x1B(?:[@-Z\\-_]|\[[0-?]*[ -/]*[@-~])")]
    private static partial Regex AnsiFilterGeneratedRegex();

    internal static string RemoveAnsiEscapes(string text) =>
        FilterAnsiEscapes.Replace(text, "");
}