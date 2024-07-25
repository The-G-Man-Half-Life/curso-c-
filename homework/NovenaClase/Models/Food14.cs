namespace NovenaClase.Models;

public class Food14:Products14
{
    public DateTime ExpirationDate {get; set;}
    public string KindOfFood {get; set;}
    public bool IsRefrigerated {get; set;}


    public Food14(string Name,string ProducerBrand,int AmountOfProducts,double OriginalCostPerUnity,DateTime ExpirationDate ,string KindOfFood ,bool IsRefrigerated):base(Name,ProducerBrand,AmountOfProducts,OriginalCostPerUnity)
    {
        this.ExpirationDate = ExpirationDate;
        this.KindOfFood = KindOfFood;
        this.IsRefrigerated = IsRefrigerated;
    }
}