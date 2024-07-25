namespace NovenaClase.models;

public class Manager15: Personal15
{
    public Manager15(string Name ,string Id ,double Salary ,string Department):base(Name,Id,Salary,Department)
    {
        this.Name = Name;
        this.Id = Id;
        this.Salary = Salary;
        this.Department = Department;
    }
}