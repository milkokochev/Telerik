//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class AreaPerimerer
{
    static void Main()
    {
        float width = 0;
        float height = 0;
        float perimeter = 0;
        float area = 0;

        Console.Write("Enter width:");
        width = float.Parse(Console.ReadLine());
        Console.Write("Enter height:");
        height = float.Parse(Console.ReadLine());

        perimeter = width * 2 + height * 2;
        area = width * height;

        Console.WriteLine("Perimeter = " + perimeter);
        Console.WriteLine("Area = " + area);

        
    }
}
