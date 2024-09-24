namespace Fresh;

public static class TextBorderizer
{
    private const char _singleVertical = '\u2502';
    private const char _singleHorizontal = '\u2500';
    private const char _doubleVertical = '\u2551';
    private const char _doubleHorizontal = '\u2550';
    private const char _squareTopLeft = '\u250C';
    private const char _squareTopRight = '\u2510';
    private const char _squareBottomLeft = '\u2514';
    private const char _squareBottomRight = '\u2518';
    private const char _roundTopLeft = '\u256D';
    private const char _roundTopRight = '\u256E';
    private const char _roundBottomLeft = '\u2570';
    private const char _roundBottomRight = '\u256F';
    private const char _doubleTopLeft = '\u2554';
    private const char _doubleTopRight = '\u2557';
    private const char _doubleBottomLeft = '\u255A';
    private const char _doubleBottomRight = '\u255D';


    public static string SquareBorder(this string text) =>
        AddBorder(text, _squareTopLeft, _squareTopRight, _squareBottomLeft, _squareBottomRight, _singleVertical, _singleHorizontal);

    public static string RoundBorder(this string text) =>
        AddBorder(text, _roundTopLeft, _roundTopRight, _roundBottomLeft, _roundBottomRight, _singleVertical, _singleHorizontal);

    public static string DoubleBorder(this string text) =>
        AddBorder(text, _doubleTopLeft, _doubleTopRight, _doubleBottomLeft, _doubleBottomRight, _doubleVertical, _doubleHorizontal);


    private static string AddBorder(
        this string text,
        char topLeft,
        char topRight,
        char bottomLeft,
        char bottomRight,
        char vertical,
        char horizontal)
    {
        var textLength = EscapeConstants.FilterAnsiEscapes.Replace(text, "").Length;

        var str = topLeft.ToString() + new string(horizontal, textLength) + topRight + Environment.NewLine;
        str += vertical + text + vertical + Environment.NewLine;
        str += bottomLeft + new string(horizontal, textLength) + bottomRight;

        return str;
    }
}