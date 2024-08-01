using EmployeesManagementSystemPart2.Models;

namespace EmployeesManagementSystem.Models;

public class Employee:Person
{
    public Guid Id {get; set;}
    public string IdentificationNumber {get; set;}
    public string Position {get; set;}
    public double Salary {get; set;}


    public Employee(string Name ,string Surname ,string IdentificationNumber ,byte Age ,string Position ,double Salary):base(Name,Surname,Age)
    {
        this.Id = new Guid();
        this.Name = Name;
        this.Surname = Surname;
        this.IdentificationNumber = IdentificationNumber;
        this.Age = Age;
        this.Position = Position;
        this.Salary = Salary;
    }


    private double CalculateBonification()
    {
        return this.Salary = (this.Salary*0.1) + (this.Salary);
    }

    public override void ShowDetails()
    {
        base.ShowDetails();
        double newSalary = CalculateBonification();
        Console.WriteLine(@$"Identification number: {this.IdentificationNumber}
Position: {this.Position}
Salary: {this.Salary}
New salary: {newSalary}");
    }
}