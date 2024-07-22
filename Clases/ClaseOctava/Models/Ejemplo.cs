using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaseOctava.Models;
public class Ejemplo
{
    public string Name {get; set;}
    public string Surname {get; set;}


    public Ejemplo(string Name, string Surname)
    {
        this.Name = Name;
        this.Surname = Surname;
    }
    

    public  void ToGreet()
    {
        Console.WriteLine($"Hola a todos soy {this.Name} {this.Surname}");
    }
}
