namespace ClaseOctava.Models;

public static class StaticExample
{
    public static string Name {get; set;}
    public static string Surname {get; set;}

    static StaticExample()
    {
        Name = "Mateo";
        Surname = "Montoya";
    }


    public static void ToGreet()
    {
        Console.WriteLine($"Hola yo soy {Name} {Surname}");
    }
}
