using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace SextaClaseTarea.Models;

public class Persona
{
    public String Nombre { get; set; }
    public int Edad { get; set; }


    public Persona(string Nombre, int Edad)
    {
        this.Nombre = Nombre;
        this.Edad = Edad;
    }
}

