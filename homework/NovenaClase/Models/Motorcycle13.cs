namespace NovenaClase.Models;

public class Motorcycle13: Vehicle13
{
    public string KindOfFuel {get; set;}
    public string KindOfMotorcycle {get; set;}

    public Motorcycle13(string Name, int Model, string WayOfTransportation, string KindOfFuel,string KindOfMotorcycle): base(Name,Model,WayOfTransportation)
    {
        this.Name = Name;
        this.Model = Model;
        this.WayOfTransportation = WayOfTransportation;
        this.KindOfFuel = KindOfFuel;
        this.KindOfMotorcycle = KindOfMotorcycle;
        StartTravel();
        StopTravel();
        ShowDetails();
    }

        public override void StartTravel()
    {
        base.StartTravel();
        Console.WriteLine("Said The motorcycle");
    }
    public override void StopTravel()
    {
        base.StopTravel();
        Console.WriteLine("Said the motorcycle");
    }
    public override void ShowDetails()
    {
        base.ShowDetails();
        Console.Write($" Kind of fuel: {this.KindOfFuel} Kind of Car: {this.KindOfMotorcycle}");
    }
}