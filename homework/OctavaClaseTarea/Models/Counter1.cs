namespace OctvaClaseTarea.Models;

public class Counter1
{
    private static int TotalCounters {get; set;}


    public static void ToIncrease()
    {
        Console.WriteLine(TotalCounters);
        TotalCounters ++;
    }
}
