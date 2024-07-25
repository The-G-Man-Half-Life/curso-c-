using System.Transactions;

namespace NovenaClase.Models;

public class Rectangle10:Figure10
{
    public override void CalculateArea()
    {
        Console.WriteLine("Enter the length a of the rectangle in meters: ");
        double lengthA = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the length b of the rectangle in meters: ");
        double lengthB = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"The area of the rectangle with side: {lengthA} m and {lengthB} m is: {lengthA * lengthB} m2");
    }
}
