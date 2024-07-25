namespace NovenaClase.Models;

public class Products14
{
    public string Name {get; set;}
    public string ProducerBrand {get; set;}
    public int AmountOfProducts {get; set;}
    public double OriginalCostPerUnity {get; set;}


    public Products14(string Name ,string ProducerBrand ,int AmountOfProducts ,double OriginalCostPerUnity)
    {
        this.Name = Name;
        this.ProducerBrand = ProducerBrand;
        this.AmountOfProducts = AmountOfProducts;
        this.OriginalCostPerUnity = OriginalCostPerUnity;
    }

    public void FinalPriceWithTaxes()
    {
        double tax = 0.19;
        double TotalPrice = (AmountOfProducts * OriginalCostPerUnity) + ((AmountOfProducts*OriginalCostPerUnity)*tax);

        Console.WriteLine("This product costs: " + TotalPrice);
    }
}