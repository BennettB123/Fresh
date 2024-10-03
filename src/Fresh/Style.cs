namespace Fresh;

public class Style
{
    private bool _foregroundSet;
    private bool _backgroundSet;
    private bool _borderStyleSet;
    private bool _borderForegroundSet;
    private bool _borderBackgroundSet;
    private bool _boldSet;
    private bool _underlineSet;
    private bool _italicSet;
    private bool _faintSet;
    private bool _blinkSet;
    private bool _strikethroughSet;
    private bool _reverseSet;

    private RGBColor _foreground;
    private RGBColor _background;
    private BorderStyle _borderStyle;
    private RGBColor _borderForeground;
    private RGBColor _borderBackground;

    public Style() { }

    public Style Foreground(RGBColor color)
    {
        _foreground = color;
        _foregroundSet = true;
        return this;
    }

    public Style Background(RGBColor color)
    {
        _background = color;
        _backgroundSet = true;
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
        _boldSet = enabled;
        return this;
    }

    public Style Faint(bool enabled)
    {
        _faintSet = enabled;
        return this;
    }

    public Style Italic(bool enabled)
    {
        _italicSet = enabled;
        return this;
    }
    public Style Underline(bool enabled)
    {
        _underlineSet = enabled;
        return this;
    }

    public Style Blink(bool enabled)
    {
        _blinkSet = enabled;
        return this;
    }

    public Style Reverse(bool enabled)
    {
        _reverseSet = enabled;
        return this;
    }

    public Style Strikethrough(bool enabled)
    {
        _strikethroughSet = enabled;
        return this;
    }

    public string Render(string text)
    {
        if (_foregroundSet)
            text = text.AddForeground(_foreground);

        if (_backgroundSet)
            text = text.AddBackground(_background);

        if (_boldSet)
            text = text.AddBold();

        if (_faintSet)
            text = text.AddFaint();

        if (_italicSet)
            text = text.AddItalic();

        if (_underlineSet)
            text = text.AddUnderline();

        if (_blinkSet)
            text = text.AddBlink();

        if (_reverseSet)
            text = text.AddReverse();

        if (_strikethroughSet)
            text = text.AddStrikethrough();

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