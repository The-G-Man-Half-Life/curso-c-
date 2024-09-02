namespace TreceavaClase.Models;
public class Owner
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Apellido { get; set; }
    public required string IdentificationNumber { get; set; }
    public required string Address { get; set; }
    public required string Phone { get; set; }
    public required string Email { get; set; }
}
