namespace Fresh;

public class Style
{
    private StyleSettings _styleSettings;
    private BorderSettings _borderSettings;

    public Style() { }

    public Style(Style s)
    {
        _styleSettings = s._styleSettings;
        _borderSettings = s._borderSettings;
    }


    public Style Foreground(RGBColor color)
    {
        _styleSettings.ForegroundColor = color;
        _styleSettings.ForegroundSet = true;
        return this;
    }

    public Style Background(RGBColor color)
    {
        _styleSettings.BackgroundColor = color;
        _styleSettings.BackgroundSet = true;
        return this;
    }

    public Style Border(BorderStyle style)
    {
        _borderSettings.Style = style;
        _borderSettings.StyleSet = true;
        _borderSettings.Characters = style switch
        {
                BorderStyle.SquareBorder => DefaultBorderCharacters.Square,
                BorderStyle.RoundBorder => DefaultBorderCharacters.Round,
                BorderStyle.DoubleBorder => DefaultBorderCharacters.Double,
                _ => DefaultBorderCharacters.Square,
        };
        return this;
    }

    public Style BorderForeground(RGBColor color)
    {
        _borderSettings.Foreground = color;
        _borderSettings.ForegroundSet = true;
        return this;
    }

    public Style BorderBackground(RGBColor color)
    {
        _borderSettings.Background = color;
        _borderSettings.BackgroundSet = true;
        return this;
    }

    public Style Bold(bool enabled)
    {
        _styleSettings.BoldSet = enabled;
        return this;
    }

    public Style Faint(bool enabled)
    {
        _styleSettings.FaintSet = enabled;
        return this;
    }

    public Style Italic(bool enabled)
    {
        _styleSettings.ItalicSet = enabled;
        return this;
    }
    public Style Underline(bool enabled)
    {
        _styleSettings.UnderlineSet = enabled;
        return this;
    }

    public Style Blink(bool enabled)
    {
        _styleSettings.BlinkSet = enabled;
        return this;
    }

    public Style Reverse(bool enabled)
    {
        _styleSettings.ReverseSet = enabled;
        return this;
    }

    public Style Strikethrough(bool enabled)
    {
        _styleSettings.StrikethroughSet = enabled;
        return this;
    }

    public string Render(string text)
    {
        text = TextCustomizer.ApplyStyle(text, _styleSettings);
        text = TextBorderizer.ApplyBorder(text, _borderSettings);

        return text;
    }
}