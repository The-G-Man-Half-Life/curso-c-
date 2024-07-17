using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace SextaClaseTarea.Models;

public class ClaseEstudiante16
{
    private string? PNombre {get; set;}
    public string? Nombre 
    {
        get{return PNombre;}
        set{PNombre = value.ToLower();}
    }
    public int Edad {get; set;}
    public string ? Grado {get; set;}


    public void GetEdad()
    {
        Console.WriteLine($"La edad es {this.Edad}");
    }
    public int SetEdad(int NuevaEdad)
    {
        this.Edad = NuevaEdad;
        return this.Edad;
    } 


    public ClaseEstudiante16(string? Nombre, int Edad, string? Grado)
    {
        this.Nombre = Nombre;
        this.Edad = Edad;
        this.Grado = Grado;
    }
}