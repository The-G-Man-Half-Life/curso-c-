namespace NovenaClase.Models;

public class Electronic14 : Products14
{
    public double EnergyConsumptionInWatts {get; set;}
    public string KindOfElectronic {get; set;}


    public Electronic14(string Name,string ProducerBrand,int AmountOfProducts,double OriginalCostPerUnity,double EnergyConsumptionInWatts,string KindOfElectronic):base(Name,ProducerBrand,AmountOfProducts,OriginalCostPerUnity)
    {
        this.EnergyConsumptionInWatts = EnergyConsumptionInWatts;
        this.KindOfElectronic = KindOfElectronic;
    }
}