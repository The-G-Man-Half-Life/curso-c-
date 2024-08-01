using EmployeesManagementSystemPart2.Models;

namespace EmployeesManagementSystem.Models;

public class Factory
{
    public string Name {get; set;}
    public string Address {get; set;}
    private List<Employee> Employees {get; set;}= new List<Employee>();
    private List<Client> Clients {get; set;} = new List<Client>();


    public Factory(string Name ,string Address,List<Employee> Employees,List<Client> Clients)
    {
        this.Name = Name;
        this.Address = Address;
        this.Employees = Employees;
        this.Clients = Clients;
    }

    public void AddANewEmployee()
    {   Console.Clear();
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


        this.Employees.Add(new Employee(newEmployeeName,newEmployeeSurname,newEmployeeId,newEmployeeAge,newEmployeePosition,newEmployeeSalary));
        Console.WriteLine("The employee was added succesfully");
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
        VisualInterfaces.EmployeesDisplay(Employees);

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
        Employees[employeeUbication].Name = newName;
        break;
    case 2:
        Console.Write("Enter the new surname: ");
        string newSurname = verificationSystem.NormalizationOfString("Enter the new surname: ");
        Employees[employeeUbication].Surname = newSurname;
        break;
    case 3:
        Console.Write("Enter the new Identification number: ");
        string newIN = verificationSystem.NormalizationOfString("Enter the new identification number: ");
        Employees[employeeUbication].Name = newIN;
        break;
    case 4:
        Console.Write("Enter the new age: ");
        byte newAge = verificationSystem.Verificatebyte("Enter the new Age: ");
        Employees[employeeUbication].Age = newAge;
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


        Clients.Add(new Client(newClientName,newClientSurname,newClientAge,newclientEmail,newClientPhone));
        Console.WriteLine("press any key to continue");
        Console.ReadKey();

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
        VisualInterfaces.ClientsDisplay(Clients);
        Console.WriteLine("press any key to continue");
        Console.ReadKey();
    }
}