namespace NovenaClase.Models;
public class Clothes14 : Products14
{
    public string Size {get; set;}
    public string KindOfFabric {get; set;}
    public string KindOfGarment {get; set;}

        public Clothes14(string Name,string ProducerBrand,int AmountOfProducts,double OriginalCostPerUnity,string Size,string KindOfFabric,string KindOfGarment):base(Name,ProducerBrand,AmountOfProducts,OriginalCostPerUnity)
    {
        this.Size = Size;
        this.KindOfFabric = KindOfFabric;
        this.KindOfGarment = KindOfGarment;
    }
}