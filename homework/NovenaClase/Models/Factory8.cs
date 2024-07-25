namespace NovenaClase.Models;

public class Factory8
{
    private List<Employee8> Employees = new List<Employee8> {
        new Employee8("santiago","director",20000),
        new Employee8("pepe","limpiador",2000000000)
    };
    public void AddEmployee()
    {
        Console.WriteLine("Enter the name of the employee: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the name of the role: ");
        string role = Console.ReadLine();
        Console.WriteLine("Enter the Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Employees.Add(new Employee8(name, role, salary));
    }
    public void FindAndEmployee(string SearchedEmployee)
    {
        var foundEmployee = Employees.Where(employee => employee.Name == SearchedEmployee);
        foreach (Employee8 employee in foundEmployee)
        {
            Console.WriteLine($"Name: {employee.Name} Role: {employee.Role} Salary: {employee.Salary}");
        }
    }
    public void ShowEmployees()
    {
        foreach (Employee8 employee in Employees)
        {
            Console.WriteLine($"Name: {employee.Name} Role: {employee.Role} Salary: {employee.Salary}");
        }
    }
}
