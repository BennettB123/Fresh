namespace Fresh;

internal static class TextBorderizer
{
    internal static string ApplyBorder(string text, BorderSettings settings)
    {
        if (!settings.StyleSet)
            return text;
        
        var textLength = EscapeConstants.RemoveAnsiEscapes(text).Length;

        var topLine = settings.Characters.TopLeft.ToString() +
            new string(settings.Characters.Horizontal, textLength) +
            settings.Characters.TopRight;

        var bottomLine = settings.Characters.BottomLeft.ToString() +
            new string(settings.Characters.Horizontal, textLength) +
            settings.Characters.BottomRight;

        var verticalStr = settings.Characters.Vertical.ToString();

        if (settings.ForegroundSet)
        {
            topLine = topLine.AddForeground(settings.Foreground);
            bottomLine = bottomLine.AddForeground(settings.Foreground);
            verticalStr = verticalStr.AddForeground(settings.Foreground);
        }
        if (settings.BackgroundSet)
        {
            topLine = topLine.AddBackground(settings.Background);
            bottomLine = bottomLine.AddBackground(settings.Background);
            verticalStr = verticalStr.AddBackground(settings.Background);
        }

        return topLine + Environment.NewLine +
            verticalStr + text + verticalStr + Environment.NewLine +
            bottomLine;
    }
}