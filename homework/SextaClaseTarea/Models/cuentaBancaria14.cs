using System.Security.Cryptography.X509Certificates;

namespace  SextaClaseTarea.Models;

public class CuentaBancaria14
{
    public string? Titular {get; set;}
    public double Saldo {get; set;}


    public double Retirar (double retiro)
    {
        if (retiro > this.Saldo)
        {
            this.Saldo =this.Saldo ;
            Console.WriteLine($"No puedes sacar mas de {this.Saldo}");
            return this.Saldo;
        }
        else 
        {
            this.Saldo = this.Saldo-retiro;
            return this.Saldo;
        }
    }


    public CuentaBancaria14 (string? Titular, double Saldo)
    {
        this.Titular = Titular;
        this.Saldo = Saldo;
    }
}