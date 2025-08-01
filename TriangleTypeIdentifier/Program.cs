using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.Write("Enter side 1: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Enter side 2: ");
        double side2 = double.Parse(Console.ReadLine());

        Console.Write("Enter side 3: ");
        double side3 = double.Parse(Console.ReadLine());

        if (side1 == side2 && side2 == side3)
            Console.WriteLine("Equilateral Triangle");
        else if (side1 == side2 || side1 == side3 || side2 == side3)
            Console.WriteLine("Isosceles Triangle");
        else
            Console.WriteLine("Scalene Triangle");
    }
}
