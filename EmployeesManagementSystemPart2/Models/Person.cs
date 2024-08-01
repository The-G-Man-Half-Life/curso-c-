using System.Diagnostics;

namespace EmployeesManagementSystemPart2.Models;

public class Person
{
    public string Name {get; set;}
    public string Surname {get; set;}
    public byte Age {get; set;}

    
    public Person(string Name ,string Surname ,byte Age)
    {
        this.Name = Name;
        this.Surname = Surname;
        this.Age = Age;
    }


    public virtual void ShowDetails()
    {
        Console.WriteLine(@$"Name: {this.Name} {this.Surname}
Age: {this.Age} years old");
    }
}