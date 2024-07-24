namespace NovenaClase.Models;

public class Store8
{
    private List<garment7> clothes = new List<garment7>{
        new garment7("blue jean","XXL",2000),
        new garment7("suite","S",15000)
    };


    public void Addgarment()
    {
        Console.WriteLine("Enter the name of the garment: ");
        string garmentName = Console.ReadLine();
        Console.WriteLine("Enter the size of the garment: ");
        string garmentSize = Console.ReadLine();
        Console.WriteLine("Enter the price of the garment: ");
        double garmentPrice = Convert.ToDouble(Console.ReadLine());

        clothes.Add(new garment7(garmentName,garmentSize,garmentPrice));
        Console.WriteLine("The garment has been added succesfully");
    }
    public void ShowClothes()
    {
        foreach (garment7 item in clothes)
        {
            Console.WriteLine($"Name: {item.Name} Size: {item.Size} Price: {item.price}");
        }
    }
    public void FindGarment(string garment)
    {
        var foundGarment = clothes.Where(cloth=>cloth.Name == garment).ToList();

        if(foundGarment.Count()<1)
        {
            Console.WriteLine("The garment is not in our database");
        }
        else
        {
        foreach (garment7 item in foundGarment)
        {
            Console.WriteLine($"Name: {item.Name} Size: {item.Size} Price: {item.price}");
        }
        }
    }
}