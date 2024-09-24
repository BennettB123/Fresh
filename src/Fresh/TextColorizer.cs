namespace Fresh;

public static class TextColorizer
{
    public static string Foreground(this string text, ushort r, ushort g, ushort b) =>
        Foreground(text, new RGBColor(r, g, b));

    public static string Foreground(this string text, RGBColor color)
    {
        return BuildForegroundRgbCommand(color) +
            text +
            EndColorCommand();
    }

    public static string Background(this string text, ushort r, ushort g, ushort b) => 
        Background(text, new RGBColor(r, g, b));

    public static string Background(this string text, RGBColor color)
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
