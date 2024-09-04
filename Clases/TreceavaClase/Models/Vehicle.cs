using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TreceavaClase.Models;

public class Vehicle
{
    public int Id {get; set;}
    public string Brand {get; set;}
    public string Model {get; set;}
    public int Year {get; set;}
    public string Color {get; set;}
    public string VehicleType {get; set;}
    public string ChasisNumber {get; set;}
    public int OwnerId {get; set;}


    //Enlaces foraneos
    // [ForeignKey("OwnerId")]
    public Owner? Owner {get; set;} 
}
