namespace SextaClaseTarea.Models;

public class ClaseEstudiante15
{
    private string? PNombre {get; set;}
    public string? Nombre 
    { 
        get{return PNombre;} 
        set{PNombre= value.ToLower();}
    }
    public int Edad { get; set;}
    public string? Grado { get; set;}

    public ClaseEstudiante15(string? Nombre, int Edad, string? Grado)
    {
        this.Nombre = Nombre;
        this.Edad = Edad;
        this.Grado = Grado;
    }
}