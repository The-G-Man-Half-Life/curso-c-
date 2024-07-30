using System.Reflection.Metadata.Ecma335;

namespace UndecimaClaseTarea.Models;

public class Coder
{
    public string Id {get; set;}
    public string Name {get; set;}
    public string Surname {get; set;}
    public string Email {get; set;}
    public string PhoneNumber {get; set;}


    public Coder(string Name ,string Surname ,string Email ,string PhoneNumber)
    {
        this.Id = new Guid().ToString().Substring(5,7);
        this.Name = Name;
        this.Surname = Surname;
        this.Email = Email;
        this.PhoneNumber = PhoneNumber;
    }
}