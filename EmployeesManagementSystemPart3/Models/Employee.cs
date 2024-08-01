using System.Reflection.Metadata.Ecma335;
using EmployeesManagementSystemPart2.Models;
using EmployeesManagementSystemPart3.Models;

namespace EmployeesManagementSystem.Models;

public class Employee: Person
{
    public string IdentificationNumber {get; set;}
    public string Position {get; set;}
    public double Salary {get; set;}


    public Employee(string Name ,string Surname ,string IdentificationNumber ,byte Age ,string Position ,double Salary):base(Name,Surname,Age)
    {
        this.IdentificationNumber = IdentificationNumber;
        this.Position = Position;
        this.Salary = Salary;
    }


    private double CalculateBonification()
    {
        return this.Salary = (this.Salary*0.1) + (this.Salary);
    }

    public override void ShowDetails()
    {

        double newSalary = CalculateBonification();
        
        
        Console.WriteLine(@$"
Full name: {this.Name} {this.Surname}
Age: {this.Age}
Identification number: {this.IdentificationNumber}
Position: {this.Position}
Salary: {this.Salary}
New salary: {newSalary}");

    }

}