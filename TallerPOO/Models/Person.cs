using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

namespace TallerPOO.Models;

public class Person
{
    protected Guid Id;
    public string Name {get; set;}
    public string Surname {get; set;}
    public string TypeOfDocument {get; set;}
    public string DocumentNumber {get; set;}
    public string Email {get; set;}
    public string PhoneNumber {get; set;}


    public Person(string Name ,string Surname ,string TypeOfDocument ,string DocumentNumber ,string Email ,string PhoneNumber)
    {
        this.Id = new Guid(); 
        this.Name = Name; 
        this.Surname = Surname; 
        this.TypeOfDocument = TypeOfDocument; 
        this.DocumentNumber = DocumentNumber; 
        this.Email = Email; 
        this.PhoneNumber = PhoneNumber; 
    }


    public virtual void ShowDetails()
    {
        Console.WriteLine(
@$"╔════════════════════════╗
║        User Details       ║
╠════════════════════════╣
║ Id:               {this.Id,-20} ║
║ Name:             {this.Name,-20} ║
║ Surname:          {this.Surname,-20} ║
║ Type of Document: {this.TypeOfDocument,-20} ║
║ Document Number:  {this.DocumentNumber,-20} ║
║ Email:            {this.Email,-20} ║
║ Phone Number:     {this.PhoneNumber,-20} ║");
    }
}