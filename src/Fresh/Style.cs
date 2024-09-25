namespace Fresh;

public class Style
{
    private bool _foregroundSet;
    private bool _backgroundSet;
    private bool _borderStyleSet;
    private bool _borderForegroundSet;
    private bool _borderBackgroundSet;

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

    public Style BorderForeground(RGBColor color) {
        _borderForeground = color;
        _borderForegroundSet = true;
        return this;
    }

    public Style BorderBackground(RGBColor color) {
        _borderBackground = color;
        _borderBackgroundSet = true;
        return this;
    }

    public string Render(string text)
    {
        if (_foregroundSet)
            text = text.AddForeground(_foreground);

        if (_backgroundSet)
            text = text.AddBackground(_background);

        if (_borderStyleSet)
            text = _borderStyle switch
            {
                BorderStyle.SquareBorder => text.SquareBorder(_borderForegroundSet,_borderBackgroundSet, _borderForeground, _borderBackground),
                BorderStyle.RoundBorder => text.RoundBorder(_borderForegroundSet, _borderBackgroundSet, _borderForeground, _borderBackground),
                BorderStyle.DoubleBorder => text.DoubleBorder(_borderForegroundSet, _borderBackgroundSet, _borderForeground, _borderBackground),
                _ => text,
            };

        return text;
    }
}