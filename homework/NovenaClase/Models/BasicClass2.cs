using System.ComponentModel;

namespace NovenaClase.Models;

public class BasicClass2
{
    public string Brand {get; set;}
    public string ComputerName {get; set;}


    public BasicClass2(string Brand, string ComputerName)
    {
        this.Brand = Brand;
        this.ComputerName = ComputerName;
    }
}
