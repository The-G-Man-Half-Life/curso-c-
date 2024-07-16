namespace SextaClaseTarea.Models;

public class Persona4
{
    private string? _Nombre;
    public string? Nombre
    {
        get { return _Nombre; }
        set { _Nombre = value.ToLower(); }
    }

    public void Saludar()
    {
        Console.WriteLine($"Hola mi nombre es: {Nombre}");
    }


    public Persona4(string Nombre)
    {
        this.Nombre = Nombre;
        Saludar();
    }


}


