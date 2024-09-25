namespace Fresh;

internal static class TextColorizer
{
    internal static string AddForeground(this string text, RGBColor color)
    {
        return BuildForegroundRgbCommand(color) +
            text +
            EndColorCommand();
    }

    internal static string AddBackground(this string text, RGBColor color)
    {
        return BuildBackgroundRgbCommand(color) +
            text +
            EndColorCommand();
    }

    private static string BuildForegroundRgbCommand(RGBColor color)
    {
        return EscapeConstants.Start +
            $"38;2;{color.R};{color.G};{color.B}" +
            EscapeConstants.GraphicsFunction;
    }

    private static string BuildBackgroundRgbCommand(RGBColor color)
    {
        return EscapeConstants.Start +
            $"48;2;{color.R};{color.G};{color.B}" +
            EscapeConstants.GraphicsFunction;
    }

    private static string EndColorCommand()
    {
        return EscapeConstants.Start + "0" + EscapeConstants.GraphicsFunction;
    }
}
