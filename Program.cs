// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

Console.WriteLine("\nEnter Length: ");
double roomLength = double.Parse(Console.ReadLine());
Console.WriteLine("\nEnter Width: ");
double roomWidth = double.Parse(Console.ReadLine());
Console.WriteLine("\nEnter Height: ");
double roomHeight = double.Parse(Console.ReadLine());

double Area = roomLength * roomWidth;
double Perimeter = (roomLength * 2) + (roomWidth * 2);
double Volume = roomWidth * roomHeight * roomLength;
double surfaceArea = (2 * (roomLength * roomHeight)) + (2 * (roomWidth * roomHeight)) + (2 * (roomLength * roomWidth));

Console.WriteLine("\nArea: "+ Area);
Console.WriteLine("\nPerimeter: " + Perimeter);
Console.WriteLine("\nVolume: " + Volume);
Console.WriteLine("\nSurface Area:" +surfaceArea);

if (Area <= 250)
{
    Console.WriteLine("\nThis is a small sized room");
} 
else if (Area > 250 && Area < 650) 
{
    Console.WriteLine("\nThis is a medium sized room");
}
else if (Area >= 650)
{
    Console.WriteLine("\nThis is a large sized room");
}

Console.WriteLine("\nThank you for using the Room Detail Generator!");