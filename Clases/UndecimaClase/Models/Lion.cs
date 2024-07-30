using UndecimaClase.Interfaces;

namespace UndecimaClase.Models;

public class Lion : Animal,IAnimal
{
    public bool Melena {get; set;}


    public Lion (string Name,Double WeightInKG,bool Melena): base(Name,WeightInKG)
    {
        this.Name = Name;
        this.WeightInKG = WeightInKG;
        this.Melena = Melena;

    }

    public void Eat(double newWeight)
    {
        Console.WriteLine($"{this.Name} is eating and now has {this.WeightInKG + newWeight} kg");
    }
    public void Sleep()
    {
        Console.WriteLine($"{this.Name} is sleeping zzzzzzzz");
    }
    public void Walk()
    {
        Console.WriteLine($"{this.Name} is walking");
    }
    public void Breath()
    {
        Console.WriteLine($"{this.Name} is breathing just aboout to kill you");
    }
    public void Move()
    {
        Console.WriteLine($"{this.Name} is moving");
    }
    public override void Reproduce()
    {
        Console.WriteLine($"{this.Name} has now 2 children");
    }
}