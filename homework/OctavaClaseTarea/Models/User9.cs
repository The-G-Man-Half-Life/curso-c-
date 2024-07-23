using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OctavaClaseTarea.Models;

public class User9
{
    public static List<string> Users {get; set;} = new List<string>{"juan","pepito","paulina","patrick the rizzman"};

    public static void TotalUsers()
    {
        Console.WriteLine($"The total of users in the database is of: {Users.Count()}");
    }
}
