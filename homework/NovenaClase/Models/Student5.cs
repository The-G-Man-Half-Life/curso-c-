using System.Reflection.Metadata.Ecma335;

namespace NovenaClase.Models;

public class Student5
{
    public string Name {get; set;}
    public int Age {get; set;}
    public string Tuition {get; set;}

    public Student5 (string Name ,int Age ,string Tuition)
    {
        this.Name = Name;
        this.Age = Age;
        this.Tuition = Tuition;
    }
}
