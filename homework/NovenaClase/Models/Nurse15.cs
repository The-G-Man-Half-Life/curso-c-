namespace NovenaClase.models;

public class Nurse15:Personal15
{
    public Nurse15(string Name ,string Id ,double Salary ,string Department):base(Name,Id,Salary,Department)
    {
        this.Name = Name;
        this.Id = Id;
        this.Salary = Salary;
        this.Department = Department;
    }
}