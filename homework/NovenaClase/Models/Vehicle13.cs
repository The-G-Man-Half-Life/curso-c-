namespace NovenaClase.Models;

public class Vehicle13
{
    public string Name {get; set;}
    public int Model {get; set;}
    public string WayOfTransportation {get; set;}

    public Vehicle13(string Name ,int Model ,string WayOfTransportation)
    {
        this.Name = Name;
        this.Model = Model;
        this.WayOfTransportation = WayOfTransportation;
    }

    public virtual void StartTravel()
    {
        Console.WriteLine($"The travel begins");
    }
    public virtual void StopTravel()
    {
        Console.WriteLine($"The travel has finished");
    }
    public virtual void ShowDetails()
    {
        Console.WriteLine(@$"Name: {this.Name} Model: {this.Model} Way of transportation: {this.WayOfTransportation}");
    }

}