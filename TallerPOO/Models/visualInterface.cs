namespace TallerPOO.Models;

public static class visualInterface
{
    public static void VisualStudentInterface(List<Student> Students)
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
                Console.WriteLine($@"|            |                  |           |            |                         |            |                  |            |            | {grade,-6:F1}|");
            }
        }
    Console.WriteLine("|____________|__________________|___________|____________|_________________________|____________|__________________|____________|____________|_______|");

    }

    public static void VisualTeacherInterface(List<Teacher> Teachers)
    {
                Console.Write(@$"____________________________________________________________________________________________________________________________________________________________
|   Nombre   |     Surname      | T.Document|  D.Number  |          Email          |  P.Number  |      Subjects    |   Salary   |Employment.D|   Courses    |
");
        foreach (Teacher teacher in Teachers)
        {
            Console.WriteLine
        (@$"|____________|__________________|___________|____________|_________________________|____________|__________________|____________|____________|______________|
|  {teacher.Name,-10}|  {teacher.Surname,-16}| {teacher.TypeOfDocument,-10}|  {teacher.DocumentNumber,-10}| {teacher.Email,-24}|  {teacher.PhoneNumber,-10}|  {teacher.Subjects,-16}|  {teacher.Salary,-10}| {teacher.EmploymentDate.ToString("yyyy/MM/dd"),-11}|              |");

            foreach (string course in teacher.Courses)
            {
                Console.WriteLine($@"|            |                  |           |            |                         |            |                  |            |            |  {course,-12:F1}|");
            }
        }
    Console.WriteLine("|____________|__________________|___________|____________|_________________________|____________|__________________|____________|____________|______________|");
    }

    public static void OptionMenu()
    {
        string menu = 
            @"
╔════════════════════════════════════════════════════════╗
║                     MAIN MENU                          ║
╠════════════════════════════════════════════════════════╣
║ 1. Find students with an average grade > 85            ║
║ 2. Get teachers who teach more than one subject        ║
║ 3. Filter students older than 16 years                 ║
║ 4. Get students ordered by last name                   ║
║ 5. Calculate total salary of all teachers              ║
║ 6. Find student with the highest grade in their course ║
║ 7. Determine the number of students in each course     ║
║ 8. Filter teachers with more than 10 years experience  ║
║ 9. Get unique subjects taught in the school            ║
║ 10. Find students with guardian name 'Maria'           ║
║ 11. Sort teachers by salary in descending order        ║
║ 12. Calculate the average age of students              ║
║ 13. Find teachers who teach 'Mathematics'              ║
║ 14. Get students with more than three grades recorded  ║
║ 15. Calculate average senitority of the teacher        ║
╠════════════════════════════════════════════════════════╣
║                  CRUD OPTIONS                          ║
╠════════════════════════════════════════════════════════╣
║ 16. Add teacher                                        ║
║ 17. Add student                                        ║
║ 18. Edit student                                       ║
║ 19. Edit teacher                                       ║
║ 20. Remove student                                     ║
║ 21. Remove teacher                                     ║
║ 22. Show student                                       ║
║ 23. Show teacher                                       ║
╠════════════════════════════════════════════════════════╣
║ 0. Exit                                                ║
╚════════════════════════════════════════════════════════╝
";
bool flag = true;
while (flag = true)
{
    Console.Write("Press any key to continue:");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine(menu);
    Console.Write("Enter the number of the option you want to execute: ");
    int option = verification.verificateMenuOption(menu);
    
    switch (option)
    {
    case 1:
    AppAdministrator.ShowStudentsWithAnAverageScoreOf85();
        break;
    case 2:
        break;
    case 3:
        break;
    case 4:
        break;
    case 5:
        break;
    case 6:
        break;
    case 7:
        break;
    case 8:
        break;
    case 9:
        break;
    case 10:
        break;
    case 11:
        break;
    case 12:
        break;
    case 13:
        break;
    case 14:
        break;
    case 15:
        break;
    case 16:
        AppAdministrator.AddANewTeacher();
        break;
    case 17:
        AppAdministrator.AddANewStudent();
        break;
    case 18:
        AppAdministrator.EditStudent();
        break;
    case 19:
        AppAdministrator.EditTeacher();
        break;
    case 20:
        AppAdministrator.DeleteStudent();
        break;
    case 21:
        AppAdministrator.DeleteTeacher();
        break;
    case 22:
        AppAdministrator.ShowStudents();
        break;
    case 23:
        AppAdministrator.ShowTeachers();
        break;
    case 0:
        Console.WriteLine("Bye bye");
        flag = false;
        break;
    default:
        Console.WriteLine("Invalid option. Please try again.");
        break;
    }
}
    }

    public static int ChangeOptions()
    {
        string menu = 
            @"
╔════════════════════════════════════════════════════════╗
║                     DETAILS MENU                       ║
╠════════════════════════════════════════════════════════╣
║ 1. name                                                ║
║ 2. surname                                             ║
║ 3. type of document                                    ║
║ 4. document number                                     ║
║ 5. email                                               ║
║ 6. phone number                                        ║
║ 7. caretaker name                                      ║
║ 8. actual course                                       ║
║ 9. birthdate                                           ║
║ 10. grades                                             ║
╚════════════════════════════════════════════════════════╝

Enter the number of the option you want to execute: ";

    int option = verification.verificateMenuOption2(menu);
    Console.Clear();
    return option;
    }

    public static int ChangeOptions2()
    {

        string menu = 
            @"
╔════════════════════════════════════════════════════════╗
║                     DETAILS MENU                       ║
╠════════════════════════════════════════════════════════╣
║ 1. name                                                ║
║ 2. surname                                             ║
║ 3. type of document                                    ║
║ 4. document number                                     ║
║ 5. email                                               ║
║ 6. phone number                                        ║
║ 7. main subject                                        ║
║ 8. salary                                              ║
║ 9. employment date                                     ║
║ 10. Course                                             ║
╚════════════════════════════════════════════════════════╝

Enter the number of the option you want to execute: ";

    int option = verification.verificateMenuOption2(menu);
    Console.Clear();
    return option;
    }
}