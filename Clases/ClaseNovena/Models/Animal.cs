namespace ClaseNOvena.Models;
public class Animal
{
    public Guid Id {get; set;}
    public string Name {get; set;}
    public string Gender {get; set;}
    public string Specie {get; set;}
    public double WeightINKG {get; set;}


public Animal(string Name ,string Gender ,string Specie ,double WeightINKG)
{
    Id = new Guid();
    this.Name = Name;
    this.Gender = Gender;
    this.Specie = Specie;
    this.WeightINKG = WeightINKG;
}
    public virtual void ToTalk()
    {
        Console.WriteLine("The animal is talking");
    }
    public virtual void ToMove()
    {
        Console.WriteLine("The animal is walking while using drops");
    }
}