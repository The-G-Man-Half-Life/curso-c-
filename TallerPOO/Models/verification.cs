namespace TallerPOO.Models;

public static class verification
{
    public static string NormalizationOfString(string word1)
    {
        bool flag = true;
        string validWord = "";

        while (flag == true)
        {

            string word = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(word) == false)
            {
                validWord = word.ToLower().Trim();
                flag = false;
            }
            else
            {
                Console.WriteLine("You must write a valid string");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(word1);
            }
        }
        Console.Clear();
        return validWord;
    }

    public static int verificateInt(string word1)
    {

        int number = 0;
        bool flag = true;

        while (flag == true)
        {

            string word = Console.ReadLine();

            if (int.TryParse(word, out number) == true && word.Contains("-") == false)
            {
                flag = false;
            }
            else
            {
                Console.WriteLine("You must write a valid number");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(word1);
            }
        }
        Console.Clear();
        return number;

    }

    public static double verificateDouble(string word1)
    {
        double number = 0;
        bool flag = true;

        while (flag == true)
        {
            string word = Console.ReadLine();

            if (double.TryParse(word, out number) == true && word.Contains("-") == false)
            {
                flag = false;
            }
            else
            {
                Console.WriteLine("You must write a valid number");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(word1);
            }
        }
        Console.Clear();
        return number;
    }

    public static string NormalizationEmail(string word1)
    {
        bool flag = true;
        string validWord = "";

        while (flag == true)
        {

            string word = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(word) == false && word.Contains("@") == true && word.Contains(".com") == true)
            {
                validWord = word.ToLower().Trim();
                flag = false;
            }
            else
            {
                Console.WriteLine("You must write a valid email");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(word1);
            }
        }
        Console.Clear();
        return validWord;
    }

    public static string verificateSubject(string word1)
    {

        int number = 0;
        bool flag = true;

        while (flag == true)
        {

            string word = Console.ReadLine();

            if (int.TryParse(word, out number) == true && number <= 8 && number >= 1)
            {
                flag = false;
            }
            else
            {
                Console.WriteLine("You must write a valid number");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(word1);
            }
        }
        switch (number)
        {
            case (1):
                Console.Clear();
                return "math";

            case (2):
                Console.Clear();
                return "physic";

            case (3):
                Console.Clear();
                return "chemistry";

            case (4):
                Console.Clear();
                return "history";

            case (5):
                Console.Clear();
                return "languages";

            case (6):
                Console.Clear();
                return "biology";

            case (7):
                Console.Clear();
                return "technology";

            case (8):
                Console.Clear();
                return "p.education";
            
            default:
            return "impossible";
        }
    }

    public static int verificateMenuOption(string word1)
    {

        int number = 0;
        bool flag = true;

        while (flag == true)
        {

            string word = Console.ReadLine();

            if (int.TryParse(word, out number) == true && number>=0 && number<=23)
            {
                flag = false;
            }
            else
            {
                Console.WriteLine("You must write a valid number");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(word1);
            }
        }
        Console.Clear();
        return number;

    }

    public static int findStudent(string word1)
    {
        bool flag = true;
        string studentId = "";
        while (flag == true)
        {

            string word = NormalizationOfString("Enter the id of the student you want to edit");
            bool studentExists = AppAdministrator.Students.Any(student=>student.DocumentNumber == word);

            if (studentExists==true)
            {
                studentId = word;
                flag = false;
            }
            else
            {
                Console.WriteLine("the student does not exist");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(word1);
            }
        }
        return AppAdministrator.Students.FindIndex(student=>student.DocumentNumber == studentId);
    }

    public static int findTeacher(string word1)
    {
        bool flag = true;
        string teacherId = "";
        while (flag == true)
        {

            string word = NormalizationOfString("Enter the id of the teacher you want to edit");
            bool teacherExists = AppAdministrator.Teachers.Any(teacher=>teacher.DocumentNumber == word);

            if (teacherExists==true)
            {
                teacherId = word;
                flag = false;
            }
            else
            {
                Console.WriteLine("the teacher does not exist");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(word1);
            }
        }
        return AppAdministrator.Teachers.FindIndex(teacher=>teacher.DocumentNumber == teacherId);
    }

    public static int verificateMenuOption2(string word1)
    {

        int number = 0;
        bool flag = true;

        while (flag == true)
        {
            Console.Write(word1);
            string word = Console.ReadLine();

            if (int.TryParse(word, out number) == true && number>=1 && number<=10)
            {
                flag = false;
            }
            else
            {
                Console.WriteLine("You must write a valid number");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(word1);
            }
        }
        return number;

    }

    public static int verificateIntYear(string word1)
    {

        int number = 0;
        bool flag = true;

        while (flag == true)
        {

            string word = Console.ReadLine();

            if (int.TryParse(word, out number) == true && number<= DateTime.Now.Year && number>=0001)
            {
                flag = false;
            }
            else
            {
                Console.WriteLine("You must write a valid year");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(word1);
            }
        }
        Console.Clear();
        return number;

    }

    public static int verificateIntMonth(string word1)
    {

        int number = 0;
        bool flag = true;

        while (flag == true)
        {

            string word = Console.ReadLine();

            if (int.TryParse(word, out number) == true && number<=12 && number>=1)
            {
                flag = false;
            }
            else
            {
                Console.WriteLine("You must write a valid month");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(word1);
            }
        }
        Console.Clear();
        return number;

    }

    public static int verificateIntDay(string word1,int month)
    {

        int number = 0;
        bool flag = true;

        while (flag == true)
        {

            string word = Console.ReadLine();

            if (int.TryParse(word, out number) == true && number<= 31 && number>=1 && month != 2)
            {
                flag = false;
            }
            else if(int.TryParse(word, out number) == true && number<= 29 && number>=1 && month == 2)
            {
                flag = false;
            }
            else
            {
                Console.WriteLine("You must write a valid year");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(word1);
            }
        }
        Console.Clear();
        return number;

    }

    public static int numberInRange(string word1, int min,int max)
    {
        int number = 0;
        bool flag = true;

        while (flag == true)
        {

            string word = Console.ReadLine();

            if (int.TryParse(word, out number) == true && number<= max && number>=min)
            {
                flag = false;
            }
            else
            {
                Console.WriteLine($"You must write a number in the range of {min} and {max}");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(word1);
            }
        }
        Console.Clear();
        return number;

    }
}