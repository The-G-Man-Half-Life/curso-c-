using NovenaClase.models;

namespace NovenaClase.Models;

public class Doctor15: Personal15
{
    public string Specialization {get; set;}
    public int YearsOfExperience {get; set;}

        public Doctor15(string Name ,string Id ,double Salary ,string Department,string Specialization,int YearsOfExperience):base(Name,Id,Salary,Department)
    {
        this.Specialization = Specialization;
        this.YearsOfExperience = YearsOfExperience;
    }


    public override void ShowDetails()
    {
        base.ShowDetails();
        Console.WriteLine(@$"
Specialization: {this.Specialization}
Years of experience: {this.YearsOfExperience}
        ");
    }
}