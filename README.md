# Fresh
Fresh is a dotnet library that makes it easy to customize console output utilizing common ANSI Escape Sequences (colors, bold, underline, etc).
It also allows you to wrap text with borders (round, square, or double lined).

<img src="https://github.com/user-attachments/assets/c98da35c-3993-4762-926d-aad002f743fd" width="200">

# Tutorial
Start by creating a new `Style` object:
``` csharp
var myStyle = new Style();
```

Here are the available methods on the `Style` object:
``` csharp
public Style Foreground(RGBColor color)         // Set the text foreground color
public Style Background(RGBColor color)         // Set the text background color
public Style Border(BorderStyle style)          // Choose a border for the text
public Style BorderForeground(RGBColor color)   // Set the border foreground color
public Style BorderBackground(RGBColor color)   // Set the border background color
public Style Bold(bool enabled)                 // Enable or disable bold text
public Style Faint(bool enabled)                // Enable or disable faint/dim text
public Style Italic(bool enabled)               // Enable or disable italic text
public Style Underline(bool enabled)            // Enable or disable underlined text
public Style Blink(bool enabled)                // Enable or disable blinking text
public Style Reverse(bool enabled)              // Enable or disable reverse text (foreground/background colors)
public Style Strikethrough(bool enabled)        // Enable or disable Strikethrough text
public Style Render(string text)                // Render the provided text string with this style
```

`RGBColor` is a struct containing `ushort` values for Red, Green, and Blue:
``` csharp
var red = new RGBColor(255, 0, 0);
```

`BorderStyle` is an enumeration to choose a border style:
``` csharp
public enum BorderStyle
{
    SquareBorder,
    RoundBorder,
    DoubleBorder,
}
```

The `Style` class supports a fluent API with method-chaining:
``` csharp
var myStyle = new Style()
    .Foreground(red)
    .Border(BorderStyle.RoundBorder)
    .BorderForeground(red)
    .Bold(true);
```

Finally, use the `Style.Render(string)` method to apply the style to the provided text and return the result as a new string:
```csharp
Console.WriteLine(myStyle.Render("This is my fresh Style!"));
```
