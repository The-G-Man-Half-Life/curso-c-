namespace SextaClaseTarea.Models;

public class Persona4
{
    private string? _Nombre;
    public string? Nombre
    {
        get { return _Nombre; }
        set { _Nombre = value.ToLower(); }
    }
    public int Edad {get; set;}

    public void MostrarDetalles()
    {
        Console.WriteLine($"Hola mi nombre es: {Nombre} y mi edad es: {Edad}");
    }


    public Persona4(string Nombre, int Edad)
    {
        this.Nombre = Nombre;
        this.Edad = Edad;
        MostrarDetalles();
    }


}


