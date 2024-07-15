namespace SextaClaseTarea.Models;

public class Persona4
{
    public string _nombre;
    private string Nombre
    {
        get{return _nombre;}
        set
        {
            _nombre.ToLower();
        }
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


