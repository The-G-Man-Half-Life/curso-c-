using System.Data;

namespace OctvaClaseTarea.Models;

public class DataBase7
{
    private static bool Connection {get; set;}


    public DataBase7()
    {
        Connection = false;
    }


    public static void ToShowConnection()
    {
        Console.WriteLine($"The database connection is in mode: {Connection}");
        Connection = Connection!;
    }

}