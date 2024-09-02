using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TreceavaClase.Models;
public class Vehicle
{
    [Key]
    public int Id {get; set;}
    public required string Brand {get; set;}
    public required string Model {get; set;}
    public required int Year {get; set;}
    public required string Color {get; set;}
    public required string VehicleType {get; set;}
    public required int OwnerId {get; set;}


    //Enlaces foraneos
    [ForeignKey("OwnerId")]
    public Owner? Owner {get; set;} 
}
