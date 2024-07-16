namespace SextaClaseTarea.Models;

public class Coche6
{
    public string? Marca {get; set;}    
    public string? Modelo {get; set;}
    public DateOnly Año {get; set;}

    public void MostrarDetalles()
    {
        Console.WriteLine($"Este coche {this.Marca} es del modelo {this.Modelo} y se creo en el año {this.Año}");
    }

    public DateOnly ActualizarAño(DateOnly NuevoAño)
    {
        Año = NuevoAño;
        return Año;
    }


    public Coche6(string? Marca, string? Modelo, DateOnly Año)
    {
        this.Marca = Marca;
        this.Modelo = Modelo;
        this.Año = Año;
    }
}

