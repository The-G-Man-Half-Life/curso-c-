namespace NovenaClase.Models;

public class BedRoom: Reservation
{
    public string RoomNumber {get; set;}
    public string TypeOfRoom {get; set;}


    public BedRoom(DateTime StartingDate,DateTime FinishingDate, string RoomNumber,string TypeOfRoom):base(StartingDate,FinishingDate)
    {
    this.RoomNumber = RoomNumber;
    this.TypeOfRoom = TypeOfRoom;
    }
}
