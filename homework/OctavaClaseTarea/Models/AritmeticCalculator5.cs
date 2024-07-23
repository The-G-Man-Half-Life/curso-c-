namespace OctvaClaseTarea.Models;

public static class AritmeticCalculator5
{
    public static void Sum(int num1, int num2)
    {
        Console.WriteLine($"The result of the sum between {num1} and {num2} is {num1 + num2}");
    }
    public static void Difference(int num1, int num2)
    {
        Console.WriteLine($"The result of the difference between {num1} and {num2} is {num1 - num2}");
    }
    public static void Multiplication(int num1, int num2)
    {
        Console.WriteLine($"The result of the multiplication between {num1} and {num2} is {num1 * num2}");
    }
    public static void Division(int num1, int num2)
    {
        Console.WriteLine($"The result of the division between {num1} and {num2} is {num1 / num2}");
    }
}