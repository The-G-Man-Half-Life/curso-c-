namespace SextaClaseTarea.Models;

public class Rectangulo17
{
    public double Ancho {get; set;}
    public double Alto {get; set;}


    public void CalcularArea()
    {
        double Area = this.Ancho * this.Alto;
        Console.WriteLine($"El area del rectangulo es {Area}");
    }


    public Rectangulo17(double Ancho, double Alto)
    {
        this.Ancho = Ancho;
        this.Alto = Alto;
    }
}