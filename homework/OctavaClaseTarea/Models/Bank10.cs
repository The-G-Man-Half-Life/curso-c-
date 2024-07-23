namespace OctavaClaseTarea.Models;

public class Bank10
{
    private static double interest {get; set;}

    static Bank10()
    {
        interest = 20;
    }
    
    public static void calculateInterest(double AmountOfCash, int year)
    {
        double totalCash = AmountOfCash;

        for (int i = 0; i < year; i++)
        {
            totalCash = totalCash + (totalCash*(interest))/100;
        }
        Console.WriteLine($"{AmountOfCash} gaining 20% of interests in {year} years gains {totalCash-AmountOfCash} giving a total of: {totalCash}");
    }
}