namespace SextaClaseTarea.Models;

public class CuentaBancaria13
{
    public string? Titular {get; set;}
    public double Saldo {get; set;}


    public double Depositar(double Ingreso)
    {
        Saldo = Saldo + Ingreso;
        return Saldo;
    }

    public CuentaBancaria13(string Titular,double Saldo)
    {
        this.Titular = Titular;
        this.Saldo = Saldo;
    }
}