Console.WriteLine("Please enter the length of the classroom. ");
double length = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter a width of the classroom");
double width = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the height of the classroom");
double height = double.Parse(Console.ReadLine());

double area = length * width;
double perimeter = 2 * (length + width);
double volume = width * length * height;
double SurfaceArea = 2*((width * length) + (height * length) + (height * width));

Console.WriteLine("area: " + area);
Console.WriteLine("perimeter: " + perimeter);
Console.WriteLine("volume: " + volume);
Console.WriteLine("surface area: " + SurfaceArea);

if(area <= 250)
{
    Console.WriteLine("this is a small room");
}
else if(area > 250 && area < 650)
{
    Console.WriteLine("this is a medium room");
}
else
{
    Console.WriteLine("this is a large room");
}