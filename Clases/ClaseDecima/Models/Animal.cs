namespace ClaseDecima.Models;

public class Animal
{
    protected int Id {get; set;}
    private string name{get; set;}
    protected string Name{ get{return name;} set{name = value.ToLower();}}
    protected string Specie {get; set;}

    public Animal(int Id, string Name, string Specie)
    {
        this.Id = Id;
        this.Name = Name;
        this.Specie = Specie;
    }
}