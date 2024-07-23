namespace OctavaClaseTarea.Models;

public static class utilityDate9
{
    public static void DaysBetweenDate(DateTime date1, DateTime date2)
    {
        TimeSpan days = date1-date2;
        Console.WriteLine($"The difference in days between {date1.ToString("yyyy/MM/dd")} and {date2.ToString("yyyy/MM/dd")} is of: {days}");
    }
}