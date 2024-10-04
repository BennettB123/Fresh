namespace Fresh;

public class Style
{
    private StyleSettings _styleSettings;
    private bool _borderStyleSet;
    private bool _borderForegroundSet;
    private bool _borderBackgroundSet;
    private BorderStyle _borderStyle;
    private RGBColor _borderForeground;
    private RGBColor _borderBackground;

    public Style() { }

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
        _borderStyle = style;
        _borderStyleSet = true;
        return this;
    }

    public Style BorderForeground(RGBColor color)
    {
        _borderForeground = color;
        _borderForegroundSet = true;
        return this;
    }

    public Style BorderBackground(RGBColor color)
    {
        _borderBackground = color;
        _borderBackgroundSet = true;
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

        if (_borderStyleSet)
            text = _borderStyle switch
            {
                BorderStyle.SquareBorder => text.SquareBorder(_borderForegroundSet, _borderBackgroundSet, _borderForeground, _borderBackground),
                BorderStyle.RoundBorder => text.RoundBorder(_borderForegroundSet, _borderBackgroundSet, _borderForeground, _borderBackground),
                BorderStyle.DoubleBorder => text.DoubleBorder(_borderForegroundSet, _borderBackgroundSet, _borderForeground, _borderBackground),
                _ => text,
            };

        return text;
    }
}