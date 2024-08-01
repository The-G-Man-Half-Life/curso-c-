namespace EmployeesManagementSystemPart2.Models;

public class Client: Person
{
    public string Email {get; set;}
    public string Phone {get; set;}


    public Client(string Name, string Surname, byte Age, string Email,string Phone):base(Name,Surname,Age)
    {
        this.Email =Email;
        this.Phone = Phone;
    }


    public override void ShowDetails()
    {
        base.ShowDetails();
        Console.WriteLine(@$"Email: {this.Email}
Phone: {this.Phone}");
    }
}