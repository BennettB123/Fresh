namespace Fresh;

internal struct BorderCharacters
{
    internal char Vertical;
    internal char Horizontal;
    internal char TopLeft;
    internal char TopRight;
    internal char BottomLeft;
    internal char BottomRight;
};

internal static class DefaultBorderCharacters
{
    internal static BorderCharacters Square = new()
    {
        Vertical = '\u2502',
        Horizontal = '\u2500',
        TopLeft = '\u250C',
        TopRight = '\u2510',
        BottomLeft = '\u2514',
        BottomRight = '\u2518',
    };

    internal static BorderCharacters Round = new()
    {
        Vertical = '\u2502',
        Horizontal = '\u2500',
        TopLeft = '\u256D',
        TopRight = '\u256E',
        BottomLeft = '\u2570',
        BottomRight = '\u256F',
    };

    internal static BorderCharacters Double = new()
    {
        Vertical = '\u2551',
        Horizontal = '\u2550',
        TopLeft = '\u2554',
        TopRight = '\u2557',
        BottomLeft = '\u255A',
        BottomRight = '\u255D',
    };
}
