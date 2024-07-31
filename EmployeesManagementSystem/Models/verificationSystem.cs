using System.Transactions;

namespace EmployeesManagementSystem.Models;

public static class verificationSystem
{
    public static string NormalizationOfString(string phrase)
    {
        bool flag = true;
        string newWord = "";
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(inputWord))
            {
                Console.Clear();
                Console.WriteLine("You must write a valid Word");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                newWord = inputWord.Trim().ToLower();
                break;
            }
        }
        return newWord;
    } 

    public static double VerificateDouble(string phrase)
    {
        bool flag = true;
        double newNumber = 0;
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (double.TryParse(inputWord, out newNumber)== false || inputWord.Contains("-"))
            {
                Console.Clear();
                Console.WriteLine("You must write a valid number");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                break;
            }
        }
        return newNumber;
    } 

    public static byte Verificatebyte(string phrase)
    {
        bool flag = true;
        byte newNumber = 0;
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (byte.TryParse(inputWord, out newNumber)== false || inputWord.Contains("-"))
            {
                Console.Clear();
                Console.WriteLine("You must write a valid age");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                break;
            }
        }
        return newNumber;
    } 

    public static int verificateExistence(List<Employee> list, string phrase)
    {
        bool flag = true;
        int employeeUbication= 0;
        
        while(flag==true)
        {
            string inputWord = NormalizationOfString(phrase);
            bool employeeExistst = list.Any(item=>item.IdentificationNumber == inputWord);

            if (employeeExistst == false)
            {
                Console.Clear();
                Console.WriteLine("The employee doesnt exist keep trying");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                employeeUbication = list.FindIndex(employee => employee.IdentificationNumber == inputWord);
                break;
            }
        }
        return employeeUbication;
    }

    public static List<Employee> verificateRoleExistence(List<Employee> list, string phrase)
    {
        bool flag = true;
        List<Employee> EmployeesWithRole= new List<Employee>();
        
        while(flag==true)
        {
            string inputWord = NormalizationOfString(phrase);
            bool employeeExistst = list.Any(item=>item.Position == inputWord);

            if (employeeExistst == false)
            {
                Console.Clear();
                Console.WriteLine("The role doesnt exist keep trying");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                EmployeesWithRole = list.Where(employee => employee.Position == inputWord).ToList();
                break;
            }
        }
        return EmployeesWithRole;
    }
}
