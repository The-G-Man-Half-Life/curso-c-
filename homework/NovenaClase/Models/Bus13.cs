using System.Globalization;

namespace NovenaClase.Models;

public class Bus13: Vehicle13
{
    public string Size {get; set;}
    public int AmountOfWheels {get; set;}
    public string KindOfFuel {get; set;}
    public string KindOfBus {get; set;}


    public  Bus13(string Name,int Model,string WayOfTransportation,string Size, int AmountOfWheels, string KindOfFuel, string KindOfBus):base(Name,Model,WayOfTransportation)
    {
        this.Name = Name;
        this.Model = Model;
        this.WayOfTransportation = WayOfTransportation;
        this.Size = Size;
        this.AmountOfWheels = AmountOfWheels;
        this.KindOfFuel = KindOfFuel;
        this.KindOfBus = KindOfBus;
    }


        public override void StartTravel()
    {
        base.StartTravel();
        Console.WriteLine("Said The Bus");
    }
    public override void StopTravel()
    {
        base.StopTravel();
        Console.WriteLine("Said the Bus");
    }
    public override void ShowDetails()
    {
        base.ShowDetails();
        Console.Write($"Size: {this.Size} Amount of Wheels: {this.AmountOfWheels} Kind of fuel: {this.KindOfFuel} Kind of Car: {this.KindOfBus}");
    }
}