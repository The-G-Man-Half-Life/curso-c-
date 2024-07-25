namespace NovenaClase.Models;

public class Manager12:Employee12
{
    public override void ToWork()
    {
        base.ToWork();
        Console.WriteLine("The manager is managing");
    }
}
