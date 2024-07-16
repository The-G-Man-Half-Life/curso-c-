namespace SextaClaseTarea.Models;

public class Producto12
{
    private string PNombre {get; set;}
    public string Nombre 
    {
        get{return PNombre;}
        set{PNombre = value.ToLower();}
    }
    public double Precio {get; set;}


    public void ObtenerNombre()
    {
        Console.WriteLine(Nombre);
    }
    public string CambiarNombre(string nuevoNombre)
    {
        Nombre = nuevoNombre;
        return Nombre;
    }

    public Producto12(string Nombre, double Precio)
    {
        this.Nombre = Nombre;
        this.Precio = Precio;
    }

}
