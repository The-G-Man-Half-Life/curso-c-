using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TreceavaClase.Models;
public class Owner
{
    [Key]
    public int Id { get; set; }

    [MinLength(5,ErrorMessage = "The full name must be at least {5} character")]
    [MaxLength(125,ErrorMessage = "The name field must be at most {125} characters")]
    public required string Name { get; set; }
    
    public required string LastName { get; set; }
    public required string IdentificationNumber { get; set; }
    
    [MaxLength(100,ErrorMessage ="The profile photo must be at most 100 characters")]
    [Url(ErrorMessage = "The profile photo must be a valid url")]
    public required string ProfilePhoto {get; set;}
    public required string Address { get; set; }
    
    [MinLength(5,ErrorMessage = "The phone field must have at least 5 characters")]
    [MaxLength(255,ErrorMessage = "The phone field must have at most 255 characters ")]
    [Phone(ErrorMessage = "The phone format is not valid, ")]
    public required string Phone { get; set; }

    [EmailAddress(ErrorMessage = "This email field is using an invalid email format")]
    public required string Email { get; set; }

    [NotMapped]
    public required string HairColor {get; set;}


    [JsonIgnore]
    public virtual ICollection<Vehicle>? Vehicles {get; set;}
}
