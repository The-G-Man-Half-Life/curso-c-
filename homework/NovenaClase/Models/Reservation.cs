namespace NovenaClase.Models;

public class Reservation
{
    public DateTime StartingDate {get; set;}
    public DateTime FinishingDate {get; set;}


    public Reservation(DateTime StartingDate ,DateTime FinishingDate)
    {
        this.StartingDate = StartingDate;
        this.FinishingDate = FinishingDate;
    }
}
