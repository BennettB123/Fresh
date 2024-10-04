using System.Text.RegularExpressions;

namespace Fresh;

internal static partial class EscapeConstants
{
    internal const string ANSIStart = "\x1b[";
    internal const string ANSIGraphicsFunction = "m";
    internal const string BoldGraphicsCommand = "1";
    internal const string FaintGraphicsCommand = "2";
    internal const string ItalicGraphicsCommand = "3";
    internal const string UnderlineGraphicsCommand = "4";
    internal const string BlinkGraphicsCommand = "5";
    internal const string ReverseGraphicsCommand = "7";
    internal const string StrikethroughGraphicsCommand = "9";

    private static Regex FilterAnsiEscapes = AnsiFilterGeneratedRegex();

    [GeneratedRegex(@"\x1B(?:[@-Z\\-_]|\[[0-?]*[ -/]*[@-~])")]
    private static partial Regex AnsiFilterGeneratedRegex();

    internal static string RemoveAnsiEscapes(string text) =>
        FilterAnsiEscapes.Replace(text, "");
}