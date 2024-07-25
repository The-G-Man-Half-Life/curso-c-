namespace TallerPOO.Models;

public class Student: Person
{
    public string CareTaker {get; set;}
    public string ActualCourse {get; set;} 
    public DateOnly BirthDate {get; set;}
    public List<double> Grades = new List<double>();


        public Student(string Name ,string Surname ,string TypeOfDocument ,string DocumentNumber ,string Email ,string PhoneNumber,string CareTaker ,string ActualCourse ,DateOnly BirthDate, List<double> Grades):base(Name ,Surname ,TypeOfDocument ,DocumentNumber ,Email ,PhoneNumber)
    {
        this.CareTaker = CareTaker;
        this.ActualCourse = ActualCourse;
        this.BirthDate = BirthDate;
        this.Grades = Grades;
    }


    public void AddGrade()
    {
        Console.Write("Enter a new grade: ");
        double grade = verification.verificateDouble("Enter a new grade: ");
        Console.WriteLine("Grade added succesfully");
        Grades.Add(grade);
    }
    private void CalculateGradesAverage()
    {
        double Average = Grades.Average();
        Console.WriteLine($"The average of grades of the student {this.Name} is {Average}");
    }

    public void CalculateAge()
    {
        int year = 0;
        if(DateTime.Now.Month < this.BirthDate.Month)
        {
            year = DateTime.Now.Year - this.BirthDate.Year;
        }
        else if(DateTime.Now.Month == this.BirthDate.Month && DateTime.Now.Day<=this.BirthDate.Day)
        {
            year = DateTime.Now.Year - this.BirthDate.Year;
        }
        else
        {
            year = (DateTime.Now.Year - this.BirthDate.Year)-1;
        }
        Console.WriteLine($"The student has {year} years");
    }

}