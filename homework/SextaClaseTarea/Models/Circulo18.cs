namespace SextaClaseTarea.Models;

public class Circulo18
{
    public double Radio {get; set;}


    public void CalcularCircunferencia()
    {
        double circunferencia = 2 * Math.PI * Radio;
        Console.WriteLine(circunferencia);
    }

    public Circulo18(double Radio)
    {
        this.Radio = Radio;
    }
}