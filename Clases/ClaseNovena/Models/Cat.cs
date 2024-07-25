namespace ClaseNOvena.Models;

public class Cat : Animal
{
    public double MustacheSize { get; set; }
    public bool EarSize { get; set; }

    public Cat(string Name, string Gender, string Specie, double WeightINKG) : base(Name, Gender, Specie, WeightINKG)
    {
        this.MustacheSize = MustacheSize;
        this.EarSize = EarSize;
    }

    public override void ToTalk()
    {
        base.ToTalk();
        Console.WriteLine("The cat says patrick the rizzman");
    }
    public override void ToMove()
    {
        base.ToMove();
        Console.WriteLine("The cat is using Busuu");
    }
}
