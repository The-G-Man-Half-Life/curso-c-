namespace ClaseOctava.Models;

public class HybridExample
{
    private int Id {get; set;}
    public string Name {get; set;}
    public string Surname {get; set;}
    public byte HeightInCm {get; set;}
    public static DateTime ActualTime = DateTime.Now;


    public HybridExample(int Id ,string Name ,string Surname ,byte HeightInCm)
    {
        this.Id = Id;
        this.Name = Name;
        this.Surname = Surname;
        this.HeightInCm = HeightInCm;
    }


    public void ToShowInformation()
    {
        Console.WriteLine(
@$"Id: {this.Id}
Name: {this.Name}
Surname: {this.Surname}
Height: {this.HeightInCm}");
    }


    public static void ToShowHead()
    {
        Console.WriteLine("*********************************");
        Console.WriteLine("             Details");
        Console.WriteLine("*********************************");
    }

    public static void ToshowFooter()
    {
        Console.WriteLine("--------------------------------------");
    }
}