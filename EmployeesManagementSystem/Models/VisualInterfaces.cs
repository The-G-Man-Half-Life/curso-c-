using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

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
|{item.Name,-10}|{item.Surname,-15}|{item.IdentificationNumber,-20}|{item.Age,-5}|{item.Position,-15}|{item.Salary,-15}|");
}
Console.WriteLine(@"|__________|_______________|____________________|_____|_______________|_______________|");
    }

    public static int DisplayOptions()
    {
        bool flag = true;
        int optionN = 0;
        while(flag == true)
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

if(int.TryParse(option,out optionN)== false  || optionN<1 || optionN>6)
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
        string businessAddress = verificationSystem.NormalizationOfString("Enter the address of teh factory: ");
        
        var factory = new Factory(businessName,businessAddress,new List<Employee>{
new Employee("john", "doe", "id123456789", 30, "engineer", 80000.00),
new Employee("jane", "smith", "id987654321", 28, "manager", 85000.00),
new Employee("alice", "johnson", "id112233445", 35, "ux designer", 75000.00),
new Employee("bob", "brown", "id556677889", 40, "data analyst", 78000.00),
new Employee("charlie", "davis", "id998877665", 29, "specialist", 72000.00)

        });

        while(flag == true)
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
| 7. Close System                                              |
+--------------------------------------------------------------+

choose an option: "
);


string option = verificationSystem.NormalizationOfString(
@"
+--------------------------------------------------------------+
|                     EMPLOYEE MANAGEMENT MENU                |
+--------------------------------------------------------------+
| 1. Add a new employee                                      |
| 2. Delete an employee                                      |
| 3. Show all employees                                      |
| 4. Update an employee                                      |
| 5. Find an employee                                        |
| 6. Show employees by rank                                  |
| 7. Close System                                           |
+--------------------------------------------------------------+

Choose an option: "

);

if(int.TryParse(option,out optionN)== false  || optionN<1 || optionN>7)
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
        Console.WriteLine("See you later alligator");
        flag = false;
        break;
}

}
    }
}
}
