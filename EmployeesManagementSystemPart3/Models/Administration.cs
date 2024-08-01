using EmployeesManagementSystem.Models;
using EmployeesManagementSystemPart2.Models;

namespace EmployeesManagementSystemPart3.Models;

public class Administration
{
public static Employee AddANewEmployee()
{
        Console.Clear();
        
        
        Console.Write("Enter the name of the employee: ");
        string newEmployeeName = verificationSystem.NormalizationOfString("Enter the name of the new employee: ");
        

        Console.Clear();
        
        
        Console.Write("Enter the Surname of the new employee: ");
        string newEmployeeSurname = verificationSystem.NormalizationOfString("Enter the surname of the new employee: ");
        

        Console.Clear();
        
        
        Console.Write("Enter the Id of the new employee: ");
        string newEmployeeId = verificationSystem.NormalizationOfString("Enter the Id of the new employee: ");
        

        Console.Clear();
        
        
        Console.Write("Enter the age of the new employee: ");
        byte newEmployeeAge = verificationSystem.Verificatebyte("Enter the age of the new employee: ");
        

        Console.Clear();
        
        
        Console.Write("Enter the Position of the new employee: ");
        string newEmployeePosition = verificationSystem.NormalizationOfString("Enter the position of the new employee: ");
        

        Console.Clear();
        
        
        Console.Write("Enter the salary of the new employee: ");
        double newEmployeeSalary = verificationSystem.VerificateDouble("Enter the salary of the new employee: ");


        return new Employee(newEmployeeName,newEmployeeSurname,newEmployeeId,newEmployeeAge,newEmployeePosition,newEmployeeSalary);
}
public static Client AddANewClient()
{       
        
        Console.Write("Enter the name of the new client: ");
        string newClientName = verificationSystem.NormalizationOfString("Enter the name of the new client: ");
        
        Console.Clear();

        
        
        Console.Write("Enter the surname of the new client: ");
        string newClientSurname = verificationSystem.NormalizationOfString("Enter the surname of the new client: ");
        
        Console.Clear();

        
        
        Console.Write("Enter the age of the new client: ");
        byte newClientAge = verificationSystem.Verificatebyte("Enter the age of the new client: ");
        
        Console.Clear();

        
        
        Console.Write("Enter the email of the new client: ");
        string newclientEmail = verificationSystem.VerificateEmail("Enter the email of the new client: ");
        
        Console.Clear();

        
        
        Console.Write("Enter the phone of the new number: ");
        string newClientPhone = verificationSystem.NormalizationOfString("Enter the phone of the new number: ");
        
        Console.Clear();



        return new Client(newClientName,newClientSurname,newClientAge,newclientEmail,newClientPhone);

}
}