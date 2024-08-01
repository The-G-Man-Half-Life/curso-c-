using System.Data.Common;
using System.Diagnostics;

namespace EmployeesManagementSystemPart2.Models;

public abstract class Person
{
    protected Guid Id {get; set;}
    protected string Name {get; set;}
    protected string Surname {get; set;}
    protected byte Age {get; set;}

    
    public Person(string Name ,string Surname ,byte Age)
    {
        this.Id = new Guid();
        this.Name = Name;
        this.Surname = Surname;
        this.Age = Age;
    }


    public abstract void ShowDetails();

    public string GetName()=>Name;
    public void SetName(string name)=>Name =name;

    public string GetSurname()=>Surname;
    public void SetSurname(string surname)=>Surname=surname;

    public byte GetAge()=>Age;
    public void SetAge(byte age)=>Age = age;
}