using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SextaClase.Models;

public class Person
{
    public int Id {get; set;}
    public string? Nombre {get; set;}
    public string? Genero {get; set;} 
    public string? Nacionalidad {get; set;}
    public string? Telefono {get; set;}
    public string? Correo {get; set;}
    public DateOnly FechaDeNacimiento {get; set;}

    public void Saludar(){
        Console.WriteLine($"Hola, mi nombre es {this.Nombre}");
    }

    public void Despedirme(){
        Console.WriteLine($"Adios, mi nombre es {this.Nombre}");
    }


    public Person(int Id, string Nombre,string Genero,string Nacionalidad,string Telefono,string Correo,DateOnly FechaDeNacimiento)
    {
        this.Id = Id; 
        this.Nombre = Nombre;
        this.Genero = Genero;
        this.Nacionalidad = Nacionalidad;
        this.Telefono = Telefono;
        this.Correo = Correo;
        this.FechaDeNacimiento = FechaDeNacimiento;

        Saludar();
        Despedirme();
    }
}
