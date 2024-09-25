using Fresh;

var red = new RGBColor(255, 0, 0);
var green = new RGBColor(0, 150, 0);
var blue = new RGBColor(0, 0, 255);
var yellow = new RGBColor(255, 255, 0);

// Testing colored text
Console.WriteLine(new Style().Foreground(red).Render("red foreground"));
Console.WriteLine(new Style().Background(green).Render("green background"));
Console.WriteLine(new Style().Foreground(red).Background(blue).Render("red text, blue background"));

// Testing bordered text
Console.WriteLine(new Style().Border(BorderStyle.SquareBorder).Render("Square Border"));
Console.WriteLine(new Style().Border(BorderStyle.RoundBorder).Render("Round Border"));
Console.WriteLine(new Style().Border(BorderStyle.DoubleBorder).Render("Double Border"));

// Testing Everything
var myStyle = new Style()
    .Foreground(yellow)
    .Background(green)
    .Border(BorderStyle.RoundBorder);
Console.WriteLine(myStyle.Render("this is my style"));