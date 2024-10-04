using System.Text;

namespace Fresh;

internal static class TextCustomizer
{
    internal static string ApplyStyle(string text, StyleSettings styleSettings)
    {
        StringBuilder graphicsCommand = new(EscapeConstants.ANSIStart);

        if (styleSettings.ForegroundSet)
            graphicsCommand.Append(';').Append(BuildForegroundRgbCommand(styleSettings.ForegroundColor));

        if (styleSettings.BackgroundSet)
            graphicsCommand.Append(';').Append(BuildBackgroundRgbCommand(styleSettings.BackgroundColor));

        if (styleSettings.BoldSet)
            graphicsCommand.Append(';').Append(EscapeConstants.BoldGraphicsCommand);

        if (styleSettings.FaintSet)
            graphicsCommand.Append(';').Append(EscapeConstants.FaintGraphicsCommand);

        if (styleSettings.ItalicSet)
            graphicsCommand.Append(';').Append(EscapeConstants.ItalicGraphicsCommand);

        if (styleSettings.UnderlineSet)
            graphicsCommand.Append(';').Append(EscapeConstants.UnderlineGraphicsCommand);

        if (styleSettings.BlinkSet)
            graphicsCommand.Append(';').Append(EscapeConstants.BlinkGraphicsCommand);

        if (styleSettings.ReverseSet)
            graphicsCommand.Append(';').Append(EscapeConstants.ReverseGraphicsCommand);

        if (styleSettings.StrikethroughSet)
            graphicsCommand.Append(';').Append(EscapeConstants.StrikethroughGraphicsCommand);

        graphicsCommand.Append(EscapeConstants.ANSIGraphicsFunction);
        return graphicsCommand + text + ResetGraphicsCommand();
    }

    internal static string AddForeground(this string text, RGBColor color)
    {
        return EscapeConstants.ANSIStart +
            BuildForegroundRgbCommand(color) +
            EscapeConstants.ANSIGraphicsFunction +
            text +
            ResetGraphicsCommand();
    }

    internal static string AddBackground(this string text, RGBColor color)
    {
        return EscapeConstants.ANSIStart +
            BuildBackgroundRgbCommand(color) +
            EscapeConstants.ANSIGraphicsFunction +
            text +
            ResetGraphicsCommand();
    }

    private static string BuildForegroundRgbCommand(RGBColor color)
    {
        return $"38;2;{color.R};{color.G};{color.B}";
    }

    private static string BuildBackgroundRgbCommand(RGBColor color)
    {
        return $"48;2;{color.R};{color.G};{color.B}";
    }


    private static string ResetGraphicsCommand() =>
        EscapeConstants.ANSIStart + "0" + EscapeConstants.ANSIGraphicsFunction;
}
