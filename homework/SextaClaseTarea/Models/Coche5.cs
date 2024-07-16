namespace SextaClaseTarea.Models;

public class Coche5
{
    public string? Marca {get; set;}
    public string? Modelo {get; set;}
    public DateOnly Año {get; set;}

    public Coche5(string? Marca, string? Modelo, DateOnly Año)
    {
        this.Marca = Marca;
        this.Modelo = Modelo;
        this.Año = Año;
    }
}
