// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

Console.WriteLine("Enter Length: ");
double roomLength = double.Parse(Console.ReadLine());
Console.WriteLine("Enter Width: ");
double roomWidth = double.Parse(Console.ReadLine());
Console.WriteLine("Enter Height: ");
double roomHeight = double.Parse(Console.ReadLine());

double Area = roomLength * roomWidth;
double Perimeter = (roomLength * 2) + (roomWidth * 2);
double Volume = roomWidth * roomHeight * roomLength;
double surfaceArea = (2 * (roomLength * roomHeight)) + (2 * (roomWidth * roomHeight)) + (2 * (roomLength * roomWidth));

Console.WriteLine("Area: "+ Area);
Console.WriteLine("Perimeter: " + Perimeter);
Console.WriteLine("Volume: " + Volume);
Console.WriteLine("Surface Area:" +surfaceArea);

if (Perimeter <= 250)
{
    Console.WriteLine("This is a small sized room");
} 
else if (Perimeter > 250 && Perimeter < 650) 
{
    Console.WriteLine("This is a medium sized room");
}
else if (Perimeter >= 650)
{
    Console.WriteLine("This is a large sized room");
}

Console.WriteLine("Thank you for using the Room Detail Generator!");