using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OctavaClaseTarea.Models;

public class ManageInventory
{
    public static List<string> inventory {get; set;} = new List<string>{"potatoes", "poco x6 pro", "redmi buds 5", "patrick the rizzman earbuds case"};

    public static void ToShowTotalOfProducts()
    {
        Console.WriteLine($"The inventory has: {inventory.Count()}");
    }
}
