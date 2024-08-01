using EmployeesManagementSystemPart2.Models;
using EmployeesManagementSystemPart3.Models;

namespace EmployeesManagementSystem.Models;

public class Factory
{
    public string Name {get; set;}
    public string Address {get; set;}
    public List<Employee> Employees {get; set;}= new List<Employee>();
    public List<Client> Clients {get; set;} = new List<Client>();


    public Factory(string Name ,string Address,List<Employee> Employees,List<Client> Clients)
    {
        this.Name = Name;
        this.Address = Address;
        this.Employees = Employees;
        this.Clients = Clients;
    }

public void AddANewEmployee()
{
    Administration.AddANewEmployee();
}
public void DeleteAnEmployee()
{
        Console.Clear();
        
        
        Console.Write("Enter the identification number of the employee: ");
        int employeeubication = verificationSystem.verificateExistence(this.Employees,"Enter the document of the employee: ");
        

        this.Employees.RemoveAt(employeeubication);
        
        
        Console.WriteLine("The employee was removed succesfully");
        
}
public void ShowAllEmployees()
{
        
        
        Console.WriteLine("These are all the employees");
        VisualInterfaces.EmployeesDisplay(this.Employees);

        Console.WriteLine(@" 
press any key to continue");
Console.ReadKey();
        
    }
public void UpdateEmployee()
{
        
        
        Console.Write("Enter the identification number of the employee: ");
        int employeeUbication = verificationSystem.verificateExistence(Employees,"Enter the identification number of the employee: ");
        

        int optionChoosen = VisualInterfaces.DisplayOptions();

        switch (optionChoosen)
{
    case 1:
        
        
        Console.Write("Enter the new name: ");

        string newName = verificationSystem.NormalizationOfString("Enter the new name: ");
        
        Employees[employeeUbication].SetName(newName);
        break;
    case 2:
        
        
        Console.Write("Enter the new surname: ");

        string newSurname = verificationSystem.NormalizationOfString("Enter the new surname: ");
        
        Employees[employeeUbication].SetSurname(newSurname);
        break;
    case 3:
        
        
        Console.Write("Enter the new Identification number: ");

        string newIN = verificationSystem.NormalizationOfString("Enter the new identification number: ");
        
        Employees[employeeUbication].IdentificationNumber = newIN;
        break;
    case 4:
        
        
        Console.Write("Enter the new age: ");

        byte newAge = verificationSystem.Verificatebyte("Enter the new Age: ");
        
        Employees[employeeUbication].SetAge(newAge);
        break;
    case 5:
        
        
        Console.Write("Enter the new position: ");

        string newPosition = verificationSystem.NormalizationOfString("Enter the new position: ");
        
        Employees[employeeUbication].Position = newPosition;
        break;
    case 6:
        
        
        Console.Write("Enter the new salary: ");

        double newSalary = verificationSystem.VerificateDouble("Enter the new Salary: ");
        
        Employees[employeeUbication].Salary = newSalary;
        break;
}
}
public void FindEmployee()
{
        
        
        Console.Write("Enter the identification number of the employee you want to find: ");
        int EmployeeUbication = verificationSystem.verificateExistence(Employees,"Enter the identification number of the employee you want to find: ");


        List<Employee> employeeFound = new List<Employee>{Employees[EmployeeUbication]};

        
        
        VisualInterfaces.EmployeesDisplay(employeeFound);
        Console.WriteLine("press any key to continue");
        Console.ReadKey();
        
}
public void ShowEmployeesByRank()
{       
        
        
        Console.Write("Enter the name of the role to see all employees with that role: ");
        List<Employee> employeesByRank = verificationSystem.verificateRoleExistence(Employees,"Enter the name of the role to see all employees with that role: ").OrderByDescending(employee=>employee.Salary).ToList();
        

        
        
        VisualInterfaces.EmployeesDisplay(employeesByRank);
        Console.WriteLine("press any key to continue");
        Console.ReadKey();
        
}
public void AddANewClient()
{
    Administration.AddANewClient();
}
public void DeleteAClient()
{
        int clientUbication = verificationSystem.VerificateClientExistence(this.Clients);

        Clients.RemoveAt(clientUbication);
        
        
        Console.WriteLine("press any key to continue");
        Console.ReadKey();
        
}
public void ShowAllClients()
{       
        
        VisualInterfaces.ClientsDisplay(this.Clients);
        Console.WriteLine("press any key to continue");
        Console.ReadKey();
        
}
}