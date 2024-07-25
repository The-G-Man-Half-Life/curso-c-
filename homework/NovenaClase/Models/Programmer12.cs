namespace NovenaClase.Models;

public class Programmer12:Employee12
{
    public override void ToWork()
    {
        base.ToWork();
        Console.WriteLine("Programmer is coding");
    }
}
