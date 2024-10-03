namespace Fresh;

internal static class TextCustomizer
{
    internal static string AddForeground(this string text, RGBColor color)
    {
        return BuildForegroundRgbCommand(color) +
            text +
            ResetGraphicsCommand();
    }

    internal static string AddBackground(this string text, RGBColor color)
    {
        return BuildBackgroundRgbCommand(color) +
            text +
            ResetGraphicsCommand();
    }

    internal static string AddBold(this string text)
    {
        return BoldGraphicsCommand() +
            text +
            ResetGraphicsCommand();
    }

    internal static string AddFaint(this string text)
    {
        return FaintGraphicsCommand() +
            text +
            ResetGraphicsCommand();
    }

    internal static string AddItalic(this string text)
    {
        return ItalicGraphicsCommand() +
            text +
            ResetGraphicsCommand();
    }

    internal static string AddUnderline(this string text)
    {
        return UnderlineGraphicsCommand() +
            text +
            ResetGraphicsCommand();
    }

    internal static string AddBlink(this string text)
    {
        return BlinkGraphicsCommand() +
            text +
            ResetGraphicsCommand();
    }

    internal static string AddReverse(this string text)
    {
        return ReverseGraphicsCommand() +
            text +
            ResetGraphicsCommand();
    }

    internal static string AddStrikethrough(this string text)
    {
        return StrikethroughGraphicsCommand() +
            text +
            ResetGraphicsCommand();
    }

    private static string BuildForegroundRgbCommand(RGBColor color)
    {
        return EscapeConstants.ANSIStart +
            $"38;2;{color.R};{color.G};{color.B}" +
            EscapeConstants.ANSIGraphicsFunction;
    }

    private static string BuildBackgroundRgbCommand(RGBColor color)
    {
        return EscapeConstants.ANSIStart +
            $"48;2;{color.R};{color.G};{color.B}" +
            EscapeConstants.ANSIGraphicsFunction;
    }

    private static string BoldGraphicsCommand()
    {
        return EscapeConstants.ANSIStart +
            "1" + EscapeConstants.ANSIGraphicsFunction;
    }

    private static string FaintGraphicsCommand()
    {
        return EscapeConstants.ANSIStart +
            "2" + EscapeConstants.ANSIGraphicsFunction;
    }

    private static string ItalicGraphicsCommand()
    {
        return EscapeConstants.ANSIStart +
            "3" + EscapeConstants.ANSIGraphicsFunction;
    }

    private static string UnderlineGraphicsCommand()
    {
        return EscapeConstants.ANSIStart +
            "4" + EscapeConstants.ANSIGraphicsFunction;
    }

    private static string BlinkGraphicsCommand()
    {
        return EscapeConstants.ANSIStart +
            "5" + EscapeConstants.ANSIGraphicsFunction;
    }

    private static string ReverseGraphicsCommand()
    {
        return EscapeConstants.ANSIStart +
            "7" + EscapeConstants.ANSIGraphicsFunction;
    }

    private static string StrikethroughGraphicsCommand()
    {
        return EscapeConstants.ANSIStart +
            "9" + EscapeConstants.ANSIGraphicsFunction;
    }

    private static string ResetGraphicsCommand()
    {
        return EscapeConstants.ANSIStart + "0" + EscapeConstants.ANSIGraphicsFunction;
    }
}
