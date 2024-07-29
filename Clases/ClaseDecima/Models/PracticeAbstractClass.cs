namespace ClaseDecima.Models;

public abstract class PracticeAbstractClass
{
    public abstract string Name {get; set;}
    public abstract string Surname {get; set;}

    protected PracticeAbstractClass(string Name,string Surname)
    {
        this.Name = Name;
        this.Surname = Surname;
    }
}