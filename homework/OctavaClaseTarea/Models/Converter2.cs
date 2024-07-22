namespace OctvaClaseTarea.Models;

public class Converter2
{
    private double Celsius {get; set;}


    public Converter2(double Celsius)
    {
        this.Celsius = Celsius;
    }


    public void CelsiusToFarenheit()
    {
        double conversion = ((9*this.Celsius)/5) +32;
        Console.WriteLine($"{this.Celsius} celsius degrees are {conversion} farenheit degrees");
    }
}
