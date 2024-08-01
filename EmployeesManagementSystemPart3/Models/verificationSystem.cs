using System.Transactions;
using EmployeesManagementSystemPart2.Models;

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

    public static string VerificateEmail(string phrase)
    {
        bool flag = true;
        string newWord = "";
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(inputWord) || inputWord.Contains("@")== false || inputWord.Contains(".com")== false)
            {
                Console.Clear();
                Console.WriteLine("You must write a valid email");
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

    public static int VerificateClientExistence(List<Client>list)
    {
        bool flag = true;
        int clientUbication = 0;

        while (flag == true)
        {
            Console.Write("Enter the name of the client: ");
            string clientName = NormalizationOfString("Enter the name of the client: ");

            Console.Write("Enter the surname of the client: ");
            string clientSurname = NormalizationOfString("Enter the surname of the client: ");

            int clientUbicationI = list.FindIndex(client=>client.GetName() == clientName && client.GetSurname() == clientSurname);

            if(clientUbicationI == -1)
            {
                Console.Clear();
                Console.WriteLine("Your user has not been found keep trying");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();

            }
            else
            {
                clientUbication = clientUbicationI;
                flag = false;
            }
        }
        return clientUbication;
    }
}
