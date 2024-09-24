using Fresh;

var red = new RGBColor(255, 0, 0);
var green = new RGBColor(0, 150, 0);
var blue = new RGBColor(0, 0, 255);

// Testing Colored Text
Console.WriteLine("Red".Foreground(red));
Console.WriteLine("Green".Background(green));
Console.WriteLine("blue background, red text".Background(blue).Foreground(red));
Console.WriteLine("red text, blue background".Foreground(red).Background(blue));