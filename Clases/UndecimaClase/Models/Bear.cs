namespace UndecimaClase.Models;

public class Bear: Animal
{
    public bool Hibernate {get; set;}


    public Bear(string Name, double WeightInKG, bool Hibernate):base(Name,WeightInKG)
    {
        this.Name = Name;
        this.WeightInKG = WeightInKG;
        this.Hibernate = Hibernate;
    }

    public override void Eat()
    {
        Console.WriteLine($"{this.Name} is eating");
    }
    public override void Sleep()
    {
        Console.WriteLine($"{this.Name} is sleeping zzzzzzzz");
    }
    public override void Walk()
    {
        Console.WriteLine($"{this.Name} is walking");
    }
    public override void Breath()
    {
        Console.WriteLine($"{this.Name} is breathing just aboout to kill you");
    }
}