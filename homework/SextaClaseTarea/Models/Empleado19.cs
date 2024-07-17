namespace SextaClaseTarea.Models;

public class Empleado19
{
    public string? PNombre {get; set;}
    public string? Nombre
    {
        get{return PNombre;}
        set{PNombre = value.ToLower();}
    }
    public string? Puesto {get; set;}
    public int Salario {get; set;}


    public void MostrarDetalles()
    {
        Console.WriteLine($"Nombre: {this.Nombre} puesto: {this.Puesto} Salario: {this.Salario}");
    }


    public Empleado19 (string? Nombre, string? Puesto, int Salario)
    {
        this.Nombre = Nombre;
        this.Puesto = Puesto;
        this.Salario = Salario;
    }
}