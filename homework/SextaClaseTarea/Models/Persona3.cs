namespace SextaClaseTarea.Models;

public class Persona3
{
    public string Nombre {get; set;}
    public void Saludar()
    {
        Console.WriteLine($"Hola yo soy {this.Nombre}");
    }


    public Persona3(string Nombre)
    {
        this.Nombre = Nombre;
        Saludar();
    }
}