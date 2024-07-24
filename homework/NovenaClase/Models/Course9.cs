using System.Reflection.Metadata.Ecma335;

namespace NovenaClase.Models;

public class Course9
{
    public string Name {get; set;}
    public string Code {get; set;}
    public int DurationInDays {get; set;} 


    public Course9(string Name ,string Code ,int DurationInDays)
    {
        this.Name = Name;
        this.Code = Code;
        this.DurationInDays = DurationInDays;
    }
}
