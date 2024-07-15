using System.Dynamic;

namespace SextaClaseTarea.Models;

public class Persona2
{
    public string Nombre {get; set;}
    public void Saludar()
    {
        Console.WriteLine($"Hola Yo soy {this.Nombre}");
    }

    public Persona2(string Nombre)
    {
        this.Nombre = Nombre;
        Saludar();
    }
}