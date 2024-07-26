using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace TallerPOO.Models;

public static class AppAdministrator
{
    public static List<Student> Students { get; set; } = new List<Student>
    {
new Student("mateo", "montoya ospina", "cedula", "123", "mateomoospina@gmail.com", "1234", "maria", "math", new DateOnly(2023, 12, 01), new List<double> { 85.5, 100,100 }),
new Student("ana", "gómez pérez", "cedula", "456", "anagomez@gmail.com", "5678", "pablo", "math", new DateOnly(2023, 10, 15), new List<double> { 92.0, 35,20 }),
new Student("luis", "ramírez lópez", "cedula", "789", "luisramirez@gmail.com", "9101", "pedro", "math", new DateOnly(2024, 01, 20), new List<double> { 78.5, 85,20 }),
new Student("camila", "castaño ruiz", "cedula", "012", "camilacastano@gmail.com", "1121", "pablo", "history", new DateOnly(2023, 11, 10), new List<double> { 88.0, 85 }),
new Student("jorge", "bermúdez martín", "cedula", "345", "jorgebermudez@gmail.com", "3141", "maria", "languages", new DateOnly(2024, 03, 05), new List<double> { 95.5, 75 }),
new Student("sofía", "montes salazar", "cedula", "678", "sofiamontes@gmail.com", "5161", "maria", "math", new DateOnly(2023, 09, 30), new List<double> { 82.0, 86 })
    };
    public static List<Teacher> Teachers { get; set; } = new List<Teacher>{
new Teacher("carlos", "hernández", "id", "98765432", "carlos.hernandez@a.com", "09-765-432", "math", 55000.00, new DateTime(2006, 8, 22), new List<string> { "math", "physic", "chemistry" }),
new Teacher("laura", "martínez", "id", "87654321", "laura.martinez@a.com", "56-890-123", "physic", 48000.00, new DateTime(2019, 1, 10), new List<string> { "history", "languages", "biology" }),
new Teacher("luis", "garcía", "id", "76543210", "luis.garcia@example.com", "45-789-012", "chemistry", 53000.00, new DateTime(2021, 3, 14), new List<string> { "technology", "p.education", "history" }),
new Teacher("sofía", "pérez", "id", "65432109", "sofia.perez@example.com", "34-678-902", "history", 50000.00, new DateTime(2020, 6, 30), new List<string> { "math", "chemistry", "languages" }),
new Teacher("andrés", "jiménez", "id", "54321098", "andres.jimenez@a.com", "23-567-891", "languages", 57000.00, new DateTime(2022, 11, 5), new List<string> { "chemistry", "math", "physic" })

    };


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

        Console.Write(@$"
1.Math
2.Physic
3.Chemistry
4.History
5.Languages
6.Biology
7.Technology
8.P.Education

Enter the number of the subject: ");
        string studentActualCourse = verification.verificateSubject(@$"
1.Math
2.Physic
3.Chemistry
4.History
5.Languages
6.Biology
7.Technology
8.P.Education

Enter the number of the subject: ");

        Console.Write("Enter the year of birth of the student: ");
        int studentBirthYear = verification.verificateIntYear("Enter the year of birth of the student: ");

        Console.Write("Enter the month of birth of the student: ");
        int studentBirthMonth = verification.verificateIntMonth("Enter the month of birth of the student: ");

        Console.Write("Enter the day of birth of the student: ");
        int studentBirthDay = verification.verificateIntDay("Enter the day of birth of the student: ",studentBirthMonth);

        List<double> grades = new List<double>();
        while (true)
        {
            Console.Write("Enter the grade of the student: ");
            double grade = verification.verificateDouble("Enter the grade of the student: ");
            grades.Add(grade);

            Console.Write("Want to continue typing grades?(yes/no): ");
            string option = verification.NormalizationOfString("Want to continue typing grades?(yes/no): ");

            if (option == "yes")
            {
                continue;
            }
            else if (option == "no")
            {
                break;
            }
            else
            {
                Console.WriteLine("you must add a valid option ");
                break;
            }
        }

        Students.Add(new Student(studentName, studentSurname, studentDocumentName, studentDocumentNumber, studentEmail, studentPhoneNumber, studentCareTaker, studentActualCourse, new DateOnly(studentBirthYear, studentBirthMonth, studentBirthDay), grades));

        Console.WriteLine("The student was added succesfully");
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

        Console.Write(@$"
1.Math
2.Physic
3.Chemistry
4.History
5.Languages
6.Biology
7.Technology
8.P.Education

Enter the number of the subject: ");
        string teacherSubject = verification.verificateSubject(@$"
1.Math
2.Physic
3.Chemistry
4.History
5.Languages
6.Biology
7.Technology
8.P.Education

Enter the number of the subject: ");

        Console.Write("Enter the salary of the teacher: ");
        double teacherSalary = verification.verificateDouble("Enter the salary of the teacher: ");

        Console.Write("Enter the year of employment of the teacher: ");
        int teacherEmploymentYear = verification.verificateIntYear("Enter the year of employment of the teacher: ");

        Console.Write("Enter the month of birth of the teacher: ");
        int teacherEmploymentMonth = verification.verificateIntMonth("Enter the month of birth of the teacher: ");

        Console.Write("Enter the day of birth of the teacher: ");
        int teacherEmploymentDay = verification.verificateIntDay("Enter the day of birth of the teacher: ",teacherEmploymentMonth);

        List<string> courses = new List<string>();
        while (true)
        {
            Console.Write(@$"
1.Math
2.Physic
3.Chemistry
4.History
5.Languages
6.Biology
7.Technology
8.P.Education

Enter the number of the subject: ");

            string course = verification.verificateSubject(@"
1.Math
2.Physic
3.Chemistry
4.History
5.Languages
6.Biology
7.Technology
8.P.Education

Enter the number of the subject: ");
            courses.Add(course);

            Console.Write("Want to continue typing courses?(yes/no): ");
            string option = verification.NormalizationOfString("Want to continue typing courses?(yes/no): ");

            if (option == "yes")
            {
                continue;
            }
            else if (option == "no")
            {
                break;
            }
            else
            {
                Console.WriteLine("you must add a valid option ");
                break;
            }
        }

        Teachers.Add(new Teacher(teacherName, teacherSurname, teacherDocumentName, teacherDocumentNumber, teacherEmail, teacherPhoneNumber, teacherSubject, teacherSalary, new DateTime(teacherEmploymentYear, teacherEmploymentMonth, teacherEmploymentDay), courses));

        Console.WriteLine("The teacher was added succesfully");
    }

    public static void ShowStudents()
    {
        visualInterface.VisualStudentInterface(Students);
    }

    public static void ShowTeachers()
    {
        visualInterface.VisualTeacherInterface(Teachers);
    }

    public static void EditStudent()
    {
        Console.Write("Write down the id of the student you want to change something: ");
        int studentUbication  = verification.findStudent("Write down the id of the student you want to change something: ");
        int optionToChange =visualInterface.ChangeOptions();

        switch (optionToChange)
        {
            case(1):
            EditStudent1.EditName(studentUbication);
            break;
            case(2):
            EditStudent1.EditSurname(studentUbication);
            break;
            case(3):
            EditStudent1.EditTypeOfDocument(studentUbication);
            break;
            case(4):
            EditStudent1.EditDocumentNumber(studentUbication);
            break;
            case(5):
            EditStudent1.EditEmail(studentUbication);
            break;
            case(6):
            EditStudent1.EditPhoneNumber(studentUbication);
            break;
            case(7):
            EditStudent1.EditCareTaker(studentUbication);
            break;
            case(8):
            EditStudent1.EditActualCourse(studentUbication);
            break;
            case(9):
            EditStudent1.EditBirthDate(studentUbication);
            break;
            case(10):
            EditStudent1.EditGrade(studentUbication);
            break;
            default:
            break;
        }
    }

    public static void EditTeacher()
    {
        Console.Write("Write down the id of the teacher you want to change something: ");
        int teacherUbication  = verification.findTeacher("Write down the id of the teacher you want to change something: ");
        int optionToChange =visualInterface.ChangeOptions2();

        switch (optionToChange)
        {
            case(1):
            EditTeacher1.EditName(teacherUbication);
            break;
            case(2):
            EditTeacher1.EditSurname(teacherUbication);
            break;
            case(3):
            EditTeacher1.EditTypeOfDocument(teacherUbication);
            break;
            case(4):
            EditTeacher1.EditDocumentNumber(teacherUbication);
            break;
            case(5):
            EditTeacher1.EditEmail(teacherUbication);
            break;
            case(6):
            EditTeacher1.EditPhoneNumber(teacherUbication);
            break;
            case(7):
            EditTeacher1.EditSubject(teacherUbication);
            break;
            case(8):
            EditTeacher1.EditSalary(teacherUbication);
            break;
            case(9):
            EditTeacher1.EditEmploymentDate(teacherUbication);
            break;
            case(10):
            EditTeacher1.EditCourse(teacherUbication);
            break;
            default:
            break;
        }
    }

    public static void DeleteStudent()
    {
        Console.Write("Enter the id of the student: ");
        int studentUbication = verification.findStudent("Enter the id of the student: ");
        Students.RemoveAt(studentUbication);
        Console.WriteLine("The student was deleted succesfully");
    }

    public static void DeleteTeacher()
    {
        Console.Write("Enterthe id of the teacher: ");
        int teacherUbication = verification.findTeacher("Enter the id of the teacher: ");
        Teachers.RemoveAt(teacherUbication);
        Console.WriteLine("The teacher was deleted succesfully");
    }

    public static void ShowStudentsWithAnAverageScoreOf85()
    {
        List<Student> StudentsScoreOf85 = Students.Where(student=>student.Grades.Average()>=85).ToList();
        visualInterface.VisualStudentInterface(StudentsScoreOf85);
    }
    public static void ShowTeachersThatTeachMoreThan1Course()
    {
        List<Teacher> TeacherThatTeachMoreThan3Courses = Teachers.Where(teacher=>teacher.Courses.Count()>=1).ToList();
        visualInterface.VisualTeacherInterface(TeacherThatTeachMoreThan3Courses);
    }
    public static void ShowStudentsOlderThan16()
    {
        List<Student> StudentsOlderThan16 = Students.Where(student => student.CalculateAge()>=16).ToList();
        visualInterface.VisualStudentInterface(StudentsOlderThan16);
    }
    public static void ShowStudentsByAscendantSurname()
    {
        List<Student> StudentSurnameAscendant = Students.OrderBy(student=>student.Surname).ToList();
        visualInterface.VisualStudentInterface(StudentSurnameAscendant);
    }
    public static void CalculateTeachersSalary()
    {
        double teacherSalary = Teachers.Sum(teacher=>teacher.Salary);
        Console.WriteLine($"The total cost of all the teacher's salary is: {teacherSalary}");
    }
    public static void StudentWithTheHighestGrade()
    {
        List<Student> studentsWithTheHighestGrade = Students.OrderByDescending(student=>student.Grades.Average()).DistinctBy(student=>student.ActualCourse).ToList();
        visualInterface.VisualStudentInterface(studentsWithTheHighestGrade);
    }
    public static void StudentsInEachCourse()
    {
        var studentInEachCourse = Students.GroupBy(student=>student.ActualCourse).Select(group => new{
            courseName = group.First().ActualCourse,
            amountOfStudents = group.Count()
        });

        foreach (var item in studentInEachCourse)
        {
            Console.WriteLine(@$"Course: {item.courseName}   Amount of students: {item.amountOfStudents}
            ");
        }
    }

    public static void TeachersWith10YearsTenure()
    {
        List<Teacher> TeacherWithMoreThan10Years = Teachers.Where(teacher=>teacher.CalculateTenure()>=10).ToList();
        visualInterface.VisualTeacherInterface(TeacherWithMoreThan10Years);
    }

    public static void uniqueSubjects()
    {
        List<Teacher> uniqueSubjects = Teachers.DistinctBy(teacher=>teacher.Subjects).ToList();
        foreach (Teacher item in uniqueSubjects)
        {
        Console.WriteLine(item.Subjects);
        }
    }
    
    public static void CareTakerMaria()
    {
        List<Student> CareTakersMaria = Students.Where(student => student.CareTaker.Contains("maria")).ToList();
        visualInterface.VisualStudentInterface(CareTakersMaria);
    }

    public static void TeachersbySalaryDescending()
    {
        List<Teacher> teacherSalaryDescending = Teachers.OrderByDescending(teacher => teacher.Salary).ToList();
        visualInterface.VisualTeacherInterface(teacherSalaryDescending);
    }

    public static void StudentsAverageAge()
    {
        double studentAverageAge = Students.Average(student => student.CalculateAge());
        Console.WriteLine("The average age of all the students is: "+ studentAverageAge.ToString("F2"));
    }

    public static void TeachersThatTeachMath()
    {
        List<Teacher> teacherSalaryDescending = Teachers.Where(teacher=>teacher.Subjects=="math").ToList();
        visualInterface.VisualTeacherInterface(teacherSalaryDescending);
    }

    public static void MoreThan3Grades()
    {
        List<Student> studentsMoreThan3Grades = Students.Where(student => student.Grades.Count()>=3).ToList();
        visualInterface.VisualStudentInterface(studentsMoreThan3Grades);
    }
    public static void AverageTenure()
    {
        double TenureAverage = Teachers.Average(teacher=>teacher.CalculateTenure());
        Console.WriteLine("The average tenure for all the teachers is: " + TenureAverage.ToString("F2") + " years");
    }
}
