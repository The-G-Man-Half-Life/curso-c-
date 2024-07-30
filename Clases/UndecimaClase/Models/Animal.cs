namespace UndecimaClase.Models;

public abstract class Animal
{
    public string Name {get; set;}
    public double WeightInKG {get; set;}


    public Animal(string Name,double WeightInKG)
    {
        this.Name = Name;
        this.WeightInKG = WeightInKG;
    }
    public abstract void Reproduce();

}