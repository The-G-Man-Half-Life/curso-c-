namespace NovenaClase.Models;

public class Drone3
{
    private string Name {get; set;}
    private double Cost {get; set;}


    public Drone3(string Name, double Cost)
    {
    this.Name = Name;
    this.Cost = Cost;
    ShowDetails();
    }


    public void ShowDetails()
    {
        Console.WriteLine($"This drone is named: {this.Name} and it costs: {this.Cost}");
    }
}
