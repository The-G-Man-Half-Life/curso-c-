namespace NovenaClase.Models;

public class School9
{
    private List<Course9> Courses = new List<Course9>{
        new Course9("math","1jadjlk",20)
    };


    public void AddACourse()
    {
        Console.WriteLine("Enter the name of the course: ");
        string courseName = Console.ReadLine();
        Console.WriteLine("Enter the code of the course: ");
        string courseCode = Console.ReadLine();
        Console.WriteLine("Enter the duration of the course in amounf of days: ");
        int courseDays = Convert.ToInt16(Console.ReadLine());

        Courses.Add(new Course9(courseName,courseCode,courseDays));
    }
    public void findACourse(string code)
    {
        var foundCourses = Courses.Where(course=> course.Code == code);

        foreach (Course9 course in foundCourses)
        {
            Console.WriteLine($"Name: {course.Name} Code: {course.Code} Amount of Days: {course.DurationInDays}");
        }
    }
    public void ShowCourses()
    {
                foreach (Course9 course in Courses)
        {
            Console.WriteLine($"Name: {course.Name} Code: {course.Code} Amount of Days: {course.DurationInDays}");
        }
    }
}