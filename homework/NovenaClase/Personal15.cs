using System.Security.Cryptography.X509Certificates;

namespace NovenaClase.models;

public class Personal15
{
    public string Name {get; set;}
    public string Id {get; set;}
    public double Salary {get; set;}
    public string Department {get; set;}


    public Personal15(string Name ,string Id ,double Salary ,string Department)
    {
        this.Name = Name;
        this.Id = Id;
        this.Salary = Salary;
        this.Department = Department;
    }


    public virtual void ShowDetails()
    {
        Console.WriteLine(@$"
Name: {this.Name}
Id: {this.Id}
Salary: {this.Salary}
Department: {this.Department}
");
    }


    public void ShowSalary()
    {
        Console.WriteLine($"This person gains: {this.Salary}");
    }
}