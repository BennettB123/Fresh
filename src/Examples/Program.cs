using Fresh;

var red = new RGBColor(255, 0, 0);
var green = new RGBColor(0, 150, 0);
var blue = new RGBColor(0, 0, 255);
var yellow = new RGBColor(255, 255, 0);

// Testing colored text
Console.WriteLine("Red".Foreground(red));
Console.WriteLine("Green".Background(green));
Console.WriteLine("Red text, blue background".Foreground(red).Background(blue));


// Testing bordered text
Console.WriteLine("Square Border".Foreground(yellow).SquareBorder());
Console.WriteLine("Round Border".Foreground(yellow).RoundBorder());
Console.WriteLine("Double Border".Foreground(yellow).DoubleBorder());