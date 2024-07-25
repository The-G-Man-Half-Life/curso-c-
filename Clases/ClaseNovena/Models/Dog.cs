namespace ClaseNOvena.Models;

public class Dog : Animal
{
    public Dog(string Name ,string Gender ,string Specie ,double WeightINKG):base(Name,Gender,Specie,WeightINKG)
    {
        this.Name = Name;
        this.Gender = Gender;
        this.Specie = Specie;
        this.WeightINKG = WeightINKG;
    }
    public override void ToTalk()
    {
        base.ToTalk();
        Console.WriteLine("The dog says wow");
    }
    public override void ToMove()
    {
        base.ToMove();
        Console.WriteLine("The dog is using Duolingo");
    }
}
