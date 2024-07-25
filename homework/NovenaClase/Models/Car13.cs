namespace NovenaClase.Models;

public class Car13: Vehicle13
{
    public int AmountOfWheels  {get; set;}
    public string KindOfFuel {get;set;}
    public string KindOfCar {get; set;}

    public Car13(string Name, int Model, string WayOfTransportation, int AmountOfWheels, string KindOfFuel,string KindOfCar):base(Name,Model,WayOfTransportation)
    {
        this.Name = Name;
        this.Model = Model;
        this.WayOfTransportation = WayOfTransportation;
        this.AmountOfWheels = AmountOfWheels;
        this.KindOfFuel = KindOfFuel;
        this.KindOfCar = KindOfCar;
        StartTravel();
        StopTravel();
        ShowDetails();
    }


    public override void StartTravel()
    {
        base.StartTravel();
        Console.WriteLine("Said The Car");
    }
    public override void StopTravel()
    {
        base.StopTravel();
        Console.WriteLine("Said the car");
    }
    public override void ShowDetails()
    {
        base.ShowDetails();
        Console.Write($" Amount of Wheels: {this.AmountOfWheels} Kind of fuel: {this.KindOfFuel} Kind of Car: {this.KindOfCar}");
    }
}