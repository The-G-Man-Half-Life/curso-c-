using ClaseDecima.Models;

public class PracticeAbstractClassToLower : PracticeAbstractClass
{
    private string _name;
    private string _surname;

    public override string Name
    {
        get { return _name; }
        set { _name = value.ToLower() + "-"; }
    }

    public override string Surname
    {
        get { return _surname; }
        set { _surname = value.ToLower() + "-"; }
    }

    // Constructor
    public PracticeAbstractClassToLower(string Name, string Surname)
        : base(Name, Surname) 
    {
        this.Name = Name;
        this.Surname = Surname;
    }
}