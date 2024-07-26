namespace TallerPOO.Models;

public class Teacher: Person
{
    public string Subjects {get; set;}
    public double Salary {get; set;}
    public DateTime EmploymentDate {get; set;}
    public List<string> Courses = new List<string>();


    
    public Teacher(string Name ,string Surname ,string TypeOfDocument ,string DocumentNumber ,string Email ,string PhoneNumber,string Subjects,double Salary,DateTime EmploymentDate,List<string> Courses):base(Name ,Surname ,TypeOfDocument ,DocumentNumber ,Email ,PhoneNumber)
    {
        this.Subjects = Subjects;
        this.Salary = Salary;
        this.EmploymentDate = EmploymentDate;
        this.Courses = Courses;
    }


    public void CalculateTenure()
    {
        int year = 0;
        if(DateTime.Now.Month < this.EmploymentDate.Month)
        {
            year = DateTime.Now.Year - this.EmploymentDate.Year;
        }
        else if(DateTime.Now.Month == this.EmploymentDate.Month && DateTime.Now.Day<=this.EmploymentDate.Day)
        {
            year = DateTime.Now.Year - this.EmploymentDate.Year;
        }
        else
        {
            year = (DateTime.Now.Year - this.EmploymentDate.Year)-1;
        }
        Console.WriteLine($"The teacher has been in the school for {year} years");
    }
    public void ShowSalary()
    {
        Console.WriteLine($"This teacher's salary is: {this.Salary}$");
    }
}