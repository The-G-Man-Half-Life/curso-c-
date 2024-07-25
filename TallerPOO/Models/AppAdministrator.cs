namespace TallerPOO.Models;

public static class AppAdministrator
{
    public static List<Student> Students {get; set;}= new List<Student>();
    public static List<Teacher> Teachers {get; set;}= new List <Teacher>();

    
    public static void AddANewStudent()
    {
        Console.Write("Enter the name of the student: ");
        string studentName = verification.NormalizationOfString("Enter the name of the student: ");

        Console.Write("Enter the surname of the student: ");
        string studentSurname = verification.NormalizationOfString("Enter the surname of the student: ");

        Console.Write("Enter the document name of the student: ");
        string studentDocumentName = verification.NormalizationOfString("Enter the document name of the student: ");

        Console.Write("Enter the document number of the student: ");
        string studentDocumentNumber = verification.NormalizationOfString("Enter the document number of the student: ");

        Console.Write("Enter the email of the student: ");
        string studentEmail = verification.NormalizationEmail("Enter the email of the student: ");

        Console.Write("Enter the phoneNumber of the student: ");
        string studentPhoneNumber = verification.NormalizationOfString("Enter the phoneNumber of the student: ");
        
        Console.Write("Enter the name of the student's caretaker: ");
        string studentCareTaker = verification.NormalizationOfString("Enter the name of the student's caretaker: ");

        Console.Write("Enter the name of the student's actual course: ");
        string studentActualCourse = verification.NormalizationOfString("Enter the name of the student's actual course: ");

        Console.Write("Enter the year of birth of the student: ");
        int studentBirthYear = verification.verificateInt("Enter the year of birth of the student: ");

        Console.Write("Enter the month of birth of the student: ");
        int studentBirthMonth = verification.verificateInt("Enter the month of birth of the student: ");

        Console.Write("Enter the day of birth of the student: ");
        int studentBirthDay = verification.verificateInt("Enter the day of birth of the student: ");

        List<double> grades = new List<double>(); 
        while(true)
        {
            Console.Write("Enter the grade of the student: ");
            double grade = verification.verificateDouble("Enter the grade of the student: ");
            grades.Add(grade);

            Console.Write("Want to continue typing grades?(yes/no): ");
            string option = verification.NormalizationOfString("Want to continue typing grades?(yes/no): ");

            if(option == "yes")
            {
                continue;
            }
            else if( option == "no")
            {
                break;
            }
            else
            {
                Console.WriteLine("you must add a valid option ");
                break;
            }
        }

        Students.Add(new Student(studentName,studentSurname,studentDocumentName,studentDocumentNumber,studentEmail,studentPhoneNumber,studentCareTaker,studentActualCourse,new DateOnly(studentBirthYear,studentBirthMonth,studentBirthDay),grades));

        Console.WriteLine("The student was added succesfully");
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }

    public static void AddANewTeacher()
    {
        Console.Write("Enter the name of the teacher: ");
        string teacherName = verification.NormalizationOfString("Enter the name of the teacher: ");

        Console.Write("Enter the surname of the teacher: ");
        string teacherSurname = verification.NormalizationOfString("Enter the surname of the teacher: ");

        Console.Write("Enter the document name of the teacher: ");
        string teacherDocumentName = verification.NormalizationOfString("Enter the document name of the teacher: ");

        Console.Write("Enter the document number of the teacher: ");
        string teacherDocumentNumber = verification.NormalizationOfString("Enter the document number of the teacher: ");

        Console.Write("Enter the email of the teacher: ");
        string teacherEmail = verification.NormalizationEmail("Enter the email of the teacher: ");

        Console.Write("Enter the phoneNumber of the teacher: ");
        string teacherPhoneNumber = verification.NormalizationOfString("Enter the phoneNumber of the teacher: ");
        
        Console.Write("Enter the name of the teacher's subject: ");
        string teacherSubject = verification.NormalizationOfString("Enter the name of the teacher's subject: ");

        Console.Write("Enter the salary of the teacher: ");
        double teacherSalary = verification.verificateDouble("Enter the salary of the teacher: ");

        Console.Write("Enter the year of employment of the teacher: ");
        int teacherEmploymentYear = verification.verificateInt("Enter the year of employment of the teacher: ");

        Console.Write("Enter the month of birth of the teacher: ");
        int teacherEmploymentMonth = verification.verificateInt("Enter the month of birth of the teacher: ");

        Console.Write("Enter the day of birth of the teacher: ");
        int teacherEmploymentDay = verification.verificateInt("Enter the day of birth of the teacher: ");

        List<string> courses = new List<string>(); 
        while(true)
        {
            Console.Write("Enter the course of the teacher: ");
            string course = verification.NormalizationOfString("Enter the course of the teacher: ");
            courses.Add(course);

            Console.Write("Want to continue typing courses?(yes/no): ");
            string option = verification.NormalizationOfString("Want to continue typing courses?(yes/no): ");

            if(option == "yes")
            {
                continue;
            }
            else if( option == "no")
            {
                break;
            }
            else
            {
                Console.WriteLine("you must add a valid option ");
                break;
            }
        }

        Teachers.Add(new Teacher(teacherName,teacherSurname,teacherDocumentName,teacherDocumentNumber,teacherEmail,teacherPhoneNumber,teacherSubject,teacherSalary,new DateTime(teacherEmploymentYear,teacherEmploymentMonth,teacherEmploymentDay),courses));

        Console.WriteLine("The teacher was added succesfully");
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }

    public static void ShowStudents()
    {
Console.Write(@$"______________________________________________________________________________________________________________________________________________________
|   Nombre   |     Surname      | T.Document|  D.Number  |          Email          |  P.Number  |    Care taker    |  A.Course  | BirthDate  | Grades|
");
foreach (Student student in Students)
{
    Console.WriteLine
(@$"|____________|__________________|___________|____________|_________________________|____________|__________________|____________|____________|_______|
|  {student.Name,-10}|  {student.Surname,-16}| {student.TypeOfDocument,-10}|  {student.DocumentNumber,-10}| {student.Email,-24}|  {student.PhoneNumber,-10}|  {student.CareTaker,-16}|  {student.ActualCourse,-10}|  {student.BirthDate,-10}|       |");

foreach (double grade in student.Grades)
{
    Console.WriteLine($@"|            |                  |           |            |                         |            |                  |            |            | {grade,-6 :F1}|"); 
}
}
    }
}
