namespace Fresh;

public static class TextColorizer
{
    /// <summary>
    /// This method changes a string's foreground color.
    /// </summary>
    /// <param name="text">the string to modify</param>
    /// <param name="r">desired color's R value</param>
    /// <param name="g">desired color's G value</param>
    /// <param name="b">desired color's B value</param>
    /// <returns>The supplied string with the desired foreground color</returns>
    public static string Foreground(this string text, ushort r, ushort g, ushort b) =>
        Foreground(text, new RGBColor(r, g, b));


    /// <summary>
    /// This method changes a string's foreground color.
    /// </summary>
    /// <param name="text">the string to modify</param>
    /// <param name="color">the desired color</param>
    /// <returns>The supplied string with the desired foreground color</returns>
    public static string Foreground(this string text, RGBColor color)
    {
        return BuildForegroundRgbCommand(color) +
            text +
            EndColorCommand();
    }


    /// <summary>
    /// This method changes a string's background color.
    /// </summary>
    /// <param name="text">the string to modify</param>
    /// <param name="r">desired color's R value</param>
    /// <param name="g">desired color's G value</param>
    /// <param name="b">desired color's B value</param>
    /// <returns>The supplied string with the desired background color</returns>
    public static string Background(this string text, ushort r, ushort g, ushort b) =>
        Background(text, new RGBColor(r, g, b));


    /// <summary>
    /// This method changes a string's background color.
    /// </summary>
    /// <param name="text">the string to modify</param>
    /// <param name="color">the desired color</param>
    /// <returns>The supplied string with the desired background color</returns>
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
