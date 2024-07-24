namespace NovenaClase.Models;

public class Circle10:Figure10
{
    public override void CalculateArea()
    {
        Console.WriteLine("Enter the ratio of the circle:");
        double ratio= Convert.ToDouble(Console.ReadLine());
        var circleArea = Math.PI * Math.Pow(ratio,2);
        Console.WriteLine($"The area of the circle with ratio {ratio} is: {circleArea} m2 ");
    }
}
