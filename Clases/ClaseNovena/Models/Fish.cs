namespace ClaseNOvena.Models;

public class Fish : Animal
{
    public Fish(string Name, string Gender, string Specie, double WeightINKG) : base(Name, Gender, Specie, WeightINKG)
    {
        this.Name = Name;
        this.Gender = Gender;
        this.Specie = Specie;
        this.WeightINKG = WeightINKG;
    }
    public override void ToTalk()
    {
        base.ToTalk();
        Console.WriteLine("The fish says tank 3 pro is the best phone ever");
    }
    public override void ToMove()
    {
        base.ToMove();
        Console.WriteLine("The fish is using hello chinese");
    }
}