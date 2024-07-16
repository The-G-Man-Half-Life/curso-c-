namespace SextaClaseTarea.Models;

public class Calculadora10
{
    public double NumeroA {get; set;}
    public double NumeroB {get; set;}
    public double Resta {get;}
    public double Suma {get;}


    private double Sumar()
    {
        double suma = NumeroA + NumeroB;
        return suma;
    }
    private double Restar()
    {
        double resta = NumeroA - NumeroB;
        return resta;
    }


    public Calculadora10( double NumeroA,double NumeroB)
    {
        this.NumeroA = NumeroA;
        this.NumeroB = NumeroB;
        this.Resta = Restar();
        this.Suma = Sumar();
    }
}
