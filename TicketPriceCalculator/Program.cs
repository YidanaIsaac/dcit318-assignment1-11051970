using System;

class TicketPriceCalculator
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        double price = 10.0;

        if (age <= 12 || age >= 65)
            price = 7.0;

        Console.WriteLine($"Ticket Price: GHC{price}");
    }
}
