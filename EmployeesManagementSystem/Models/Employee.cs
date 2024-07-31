namespace EmployeesManagementSystem.Models;

public class Employee
{
    public Guid Id {get; set;}
    public string Name {get; set;}
    public string Surname {get; set;}
    public string IdentificationNumber {get; set;}
    public byte Age {get; set;}
    public string Position {get; set;}
    public double Salary {get; set;}


    public Employee(string Name ,string Surname ,string IdentificationNumber ,byte Age ,string Position ,double Salary)
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

    public void ShowInformation()
    {
        double newSalary = CalculateBonification();
        Console.WriteLine(@$"
Full name: {this.Name} {this.Surname}
Age: {this.Age}
Position: {this.Position}
Salary: {this.Salary}
Salary + Bonification: {newSalary}");
    }
}