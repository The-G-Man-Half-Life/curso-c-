using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OctavaClaseTarea.Models;

public class TotalRegisters
{
    public static List<string> Registers {get; set;} = new List<string>{"potatoes", "poco x6 pro", "redmi buds 5", "patrick the rizzman earbuds case"};

    public static void ToShowTotalOfRegisters()
    {
        Console.WriteLine($"The Registers has: {Registers.Count()}");
    }
}

