namespace ClaseDecima.Models;

public class Dog : Animal
{
    public bool IsCreoleBreed {get; set;}

    public Dog(int Id, string Name, string Specie, bool IsCreoleBreed):base(Id,Name,Specie)
    {
        this.IsCreoleBreed = IsCreoleBreed;
    }
    public string GetName()
    {
        return Name;
    }
}