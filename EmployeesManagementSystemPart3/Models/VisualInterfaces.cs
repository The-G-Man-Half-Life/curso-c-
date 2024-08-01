using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using EmployeesManagementSystemPart2.Models;

namespace EmployeesManagementSystem.Models;
public static class VisualInterfaces
{
    public static void EmployeesDisplay(List<Employee> list)
    {
        Console.WriteLine(@$"
_______________________________________________________________________________________
|   Name   |   Surname     | Identification N.  | Age |    Position   |    Salary     |");

        foreach (Employee item in list)
        {
            Console.WriteLine(@$"|__________|_______________|____________________|_____|_______________|_______________|
|{item.GetName(),-10}|{item.GetSurname(),-15}|{item.IdentificationNumber,-20}|{item.GetAge(),-5}|{item.Position,-15}|{item.Salary,-15}|");
        }
        Console.WriteLine(@"|__________|_______________|____________________|_____|_______________|_______________|");
    }

    public static void ClientsDisplay(List<Client> list)
    {
        Console.WriteLine(@$"
____________________________________________________________________________
|   Name   |   Surname     | Age |          Email          |    Phone      |");

        foreach (Client item in list)
        {
            Console.WriteLine(@$"|__________|_______________|_____|_________________________|_______________|
|{item.GetName(),-10}|{item.GetSurname(),-15}|{item.GetAge(),-5}|{item.Email,-25}|{item.Phone,-15}|");
        }
        Console.WriteLine(@"|__________|_______________|_____|_________________________|_______________|");
    }

    public static int DisplayOptions()
    {
        bool flag = true;
        int optionN = 0;
        while (flag == true)
        {
            Console.WriteLine(
@"
+------------------------------------------------+
|                   MENU OPTIONS                 |
+------------------------------------------------+
| 1. Name                                        |
| 2. Last Name                                   |
| 3. Identification Number                       |
| 4. Age                                         |
| 5. Position                                    |
| 6. Salary                                      |
+------------------------------------------------+

Enter the option you wish: "
);

            string option = verificationSystem.NormalizationOfString(@"
+------------------------------------------------+
|                   MENU OPTIONS                 |
+------------------------------------------------+
| 1. Name                                        |
| 2. Last Name                                   |
| 3. Identification Number                       |
| 4. Age                                         |
| 5. Position                                    |
| 6. Salary                                      |
+------------------------------------------------+

Enter the option you wish: ");

            if (int.TryParse(option, out optionN) == false || optionN < 1 || optionN > 6)
            {
                Console.WriteLine("You must write an option in the range");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                break;
            }
        }
        return optionN;
    }

    public static void ExecutionProgram()
    {
        bool flag = true;
        int optionN = 0;
        
        
        Console.Write("Enter the name of the factory: ");
        
        string businessName = verificationSystem.NormalizationOfString("Enter the name of the factory: ");

        
        
        Console.Write("Enter the address of the factory: ");
        
        string businessAddress = verificationSystem.NormalizationOfString("Enter the address of the factory: ");

        var factory = new Factory(businessName, businessAddress, new List<Employee>{
new Employee("john", "doe", "id123456789", 30, "engineer", 80000.00),
new Employee("jane", "smith", "id987654321", 28, "manager", 85000.00),
new Employee("alice", "johnson", "id112233445", 35, "ux designer", 75000.00),
new Employee("bob", "brown", "id556677889", 40, "data analyst", 78000.00),
new Employee("charlie", "davis", "id998877665", 29, "specialist", 72000.00)
}, new List<Client>{
new Client("john", "doe", 30, "john.doe@example.com", "123-456-7890"),
new Client("jane", "smith", 28, "jane.smith@example.com", "234-567-8901"),
new Client("alice", "johnson", 35, "alice.johnson@example.com", "345-678-9012"),
new Client("bob", "brown", 40, "bob.brown@example.com", "456-789-0123"),
new Client("charlie", "davis", 22, "charlie.davis@example.com", "567-890-1234"),
new Client("diana", "wilson", 27, "diana.wilson@example.com", "678-901-2345"),
new Client("eve", "miller", 33, "eve.miller@example.com", "789-012-3456"),
new Client("frank", "moore", 29, "frank.moore@example.com", "890-123-4567"),
new Client("grace", "taylor", 31, "grace.taylor@example.com", "901-234-5678"),
new Client("hank", "anderson", 38, "hank.anderson@example.com", "012-345-6789")
});

        while (flag == true)
        {

            Console.Clear();
            
            
            Console.Write(
            @"
+--------------------------------------------------------------+
|                     EMPLOYEE MANAGEMENT MENU                 |
+--------------------------------------------------------------+
| 1. Add a new employee                                        |
| 2. Delete an employee                                        |
| 3. Show all employees                                        |
| 4. Update an employee                                        |
| 5. Find an employee                                          |
| 6. Show employees by rank                                    |
| 7. Add a new client                                          |
| 8. Delete a client                                           |
| 9. Show all clients                                          |  
| 10. Close System                                             |
+--------------------------------------------------------------+

Choose an option: "
            );





            string option = verificationSystem.NormalizationOfString(
            @"
+--------------------------------------------------------------+
|                     EMPLOYEE MANAGEMENT MENU                 |
+--------------------------------------------------------------+
| 1. Add a new employee                                        |
| 2. Delete an employee                                        |
| 3. Show all employees                                        |
| 4. Update an employee                                        |
| 5. Find an employee                                          |
| 6. Show employees by rank                                    |
| 7. Add a new client                                          |
| 8. Delete a client                                           |
| 9. Show all clients                                          |  
| 10. Close System                                             |
+--------------------------------------------------------------+

Choose an option: "

            );


            if (int.TryParse(option, out optionN) == false || optionN < 1 || optionN > 10)
            {   
                
                
                Console.WriteLine("You must write an option in the range");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                
                Console.Clear();
            }
            else
            {

                switch (optionN)
                {
                    case 1:
                        Console.Clear();
                        factory.AddANewEmployee();
                        break;
                    case 2:
                        Console.Clear();
                        factory.DeleteAnEmployee();
                        break;
                    case 3:
                        Console.Clear();
                        factory.ShowAllEmployees();
                        break;
                    case 4:
                        Console.Clear();
                        factory.UpdateEmployee();
                        break;
                    case 5:
                        Console.Clear();
                        factory.FindEmployee();
                        break;
                    case 6:
                        Console.Clear();
                        factory.ShowEmployeesByRank();
                        break;
                    case 7:
                        Console.Clear();
                        factory.AddANewClient();
                        break;
                    case 8:
                        Console.Clear();
                        factory.DeleteAClient();
                        break;
                    case 9:
                        Console.Clear();
                        factory.ShowAllClients();
                        break;
                    case 10:
                        Console.Clear();
                        
                        
                        Console.WriteLine("See you later alligator");
                        
                        flag = false;
                        break;
                }

            }
        }
    }
}
