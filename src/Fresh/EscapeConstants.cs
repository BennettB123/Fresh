using System.Text.RegularExpressions;

namespace Fresh;

internal static partial class EscapeConstants
{
    internal static Regex FilterAnsiEscapes = AnsiFilterGeneratedRegex();
    internal const string Start = "\x1b[";
    internal const string GraphicsFunction = "m";


    [GeneratedRegex(@"\x1B(?:[@-Z\\-_]|\[[0-?]*[ -/]*[@-~])")]
    private static partial Regex AnsiFilterGeneratedRegex();
}