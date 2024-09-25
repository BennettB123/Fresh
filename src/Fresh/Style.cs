namespace Fresh;

public class Style
{
    private bool _foregroundSet;
    private bool _backgroundSet;
    private bool _borderStyleSet;

    private RGBColor _foreground;
    private RGBColor _background;
    private BorderStyle _borderStyle;

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

    public string Render(string text)
    {
        if (_foregroundSet)
            text = text.AddForeground(_foreground);

        if (_backgroundSet)
            text = text.AddBackground(_background);

        if (_borderStyleSet)
            text = _borderStyle switch
            {
                BorderStyle.SquareBorder => text.SquareBorder(),
                BorderStyle.RoundBorder => text.RoundBorder(),
                BorderStyle.DoubleBorder => text.DoubleBorder(),
                _ => text,
            };

        return text;
    }
}