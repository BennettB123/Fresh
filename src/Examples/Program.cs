using Fresh;

var red = new RGBColor(255, 0, 0);
var green = new RGBColor(0, 255, 0);
var blue = new RGBColor(100, 150, 255);
var yellow = new RGBColor(255, 255, 0);

// Testing empty style
Console.WriteLine(new Style().Render("No style"));

// Testing colored text
Console.WriteLine(new Style().Foreground(red).Render("red text"));
Console.WriteLine(new Style().Background(green).Render("green background"));
Console.WriteLine(new Style().Foreground(red).Background(blue).Render("red text, blue background"));

// Testing bordered text
Console.WriteLine(new Style().Border(BorderStyle.SquareBorder).Render("Square Border"));
Console.WriteLine(new Style().Border(BorderStyle.RoundBorder).Render("Round Border"));
Console.WriteLine(new Style().Border(BorderStyle.DoubleBorder).Render("Double Border"));

// Testing colored borders
Console.WriteLine(new Style()
    .Border(BorderStyle.RoundBorder)
    .BorderForeground(red)
    .Render("Red Foreground Round border"));
Console.WriteLine(new Style()
    .Border(BorderStyle.SquareBorder)
    .BorderBackground(red)
    .Render("Red Background Square border"));
Console.WriteLine(new Style()
    .Border(BorderStyle.DoubleBorder)
    .BorderForeground(red)
    .BorderBackground(yellow)
    .Render("Red Foreground Yellow Background Double border"));

// Testing Text Effects
Console.WriteLine(new Style().Bold(true).Render("Bold"));
Console.WriteLine(new Style().Underline(true).Render("Underlined"));
Console.WriteLine(new Style().Italic(true).Render("Italics"));
Console.WriteLine(new Style().Faint(true).Render("Faint"));
Console.WriteLine(new Style().Blink(true).Render("Blink"));
Console.WriteLine(new Style().Strikethrough(true).Render("Strikethrough"));
Console.WriteLine(new Style().Reverse(true).Render("Reverse"));

// Testing Everything Together
var myStyle = new Style()
    .Foreground(yellow)
    .Background(green)
    .Border(BorderStyle.RoundBorder)
    .BorderForeground(green)
    .BorderBackground(green)
    .Bold(true)
    .Underline(true)
    .Italic(true)
    .Blink(true)
    .Strikethrough(true);
Console.WriteLine(myStyle.Render("Testing Everything Together"));
