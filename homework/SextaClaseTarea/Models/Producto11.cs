namespace SextaClaseTarea.Models;

public class Producto11
{
    private string PNombre {get; set;}
    public string Nombre 
    {
        get{return PNombre;}
        set{PNombre = value.ToLower();}
    }
    public double Precio {get; set;}

    public Producto11(string Nombre, double Precio)
    {
        this.Nombre = Nombre;
        this.Precio = Precio;
    }

}
