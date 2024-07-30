using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using UndecimaClaseTarea.Interface;

namespace UndecimaClaseTarea.Models;
public class Riwi : ICRUD
{
    private List<Coder> Coders {get; set;} = new List<Coder>();


    public Riwi(List<Coder> Coders)
    {
        this.Coders = Coders;
    }

    public void AddANewCoder()
    {
        Console.WriteLine("Enter the name of the coder: ");
        string newCoderName = Console.ReadLine();

        Console.WriteLine("Enter the surname of the coder: ");
        string newCoderSurname = Console.ReadLine();

        Console.WriteLine("Enter the Email of the coder: ");
        string newCoderEmail = Console.ReadLine();

        Console.WriteLine("Enter the phone number of the coder: ");
        string newCoderPhoneNumber = Console.ReadLine();

        Coders.Add(new Coder(newCoderName,newCoderSurname,newCoderEmail,newCoderPhoneNumber));
    }

    public void DeleteACoder()
    {
        Console.WriteLine("Enter the id of the coder: ");

        string id = Console.ReadLine();

        int coderId = Coders.FindIndex(coder => coder.Id == id);

        if(coderId == -1)
        {
            Console.WriteLine("The coder doesnt exist");
        }
        else
        {
            Coders.RemoveAt(coderId);
            Console.WriteLine("The coder was removed succesfully");
        }
    }

    public void UpdateACoder()
    {
        Console.WriteLine("Enter the id of the coder: ");

        string id = Console.ReadLine();

        int coderId = Coders.FindIndex(coder => coder.Id == id);

        if(coderId != -1)
        {
            Console.WriteLine(@$"
1.Name
2.Surname
3.Email
4.Phone number

Choose the number of the option you want to execute: 
            ");

            int optionChoosen = Convert.ToInt16(Console.ReadLine());

            switch (optionChoosen)
            {
                case(1):
                Console.WriteLine("Enter the new name:");
                string newName = Console.ReadLine();
                Coders[coderId].Name = newName;
                break;
                
                case(2):
                Console.WriteLine("Enter the new surname:");
                string newSurname = Console.ReadLine();
                Coders[coderId].Surname = newSurname;
                break;
                
                case(3):
                Console.WriteLine("Enter the new email:");
                string newEmail = Console.ReadLine();
                Coders[coderId].Email = newEmail;
                break;
                
                case(4):
                Console.WriteLine("Enter the new phone number:");
                string newPhoneNumber = Console.ReadLine();
                Coders[coderId].PhoneNumber = newPhoneNumber;
                break;
            }
            Console.WriteLine("The changes were successfully made");
        }
        else
        {
            Console.WriteLine("The coder does not exist try again");
        }
    }

    public void ShowCoders()
    {

        int idWidth = 5;
        int nameWidth = 15;
        int surnameWidth = 15;
        int emailWidth = 30;
        int phoneWidth = 15;

        Console.WriteLine($"| {"Id".PadRight(idWidth)} | {"Name".PadRight(nameWidth)} | {"Surname".PadRight(surnameWidth)} | {"Email".PadRight(emailWidth)} | {"Phone Number".PadRight(phoneWidth)} |");
        Console.WriteLine(new string('-', idWidth + nameWidth + surnameWidth + emailWidth + phoneWidth + 15));

        // Imprimir las filas de la tabla
        foreach (Coder persona in Coders)
        {
            Console.WriteLine($"| {persona.Id.PadRight(idWidth)} | {persona.Name.PadRight(nameWidth)} | {persona.Surname.PadRight(surnameWidth)} | {persona.Email.PadRight(emailWidth)} | {persona.PhoneNumber.PadRight(phoneWidth)} |");
        }

        // Imprimir el final de la tabla
        Console.WriteLine(new string('-', idWidth + nameWidth + surnameWidth + emailWidth + phoneWidth + 15));
    }
}
