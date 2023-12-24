namespace Models.Entities;

[Table("ticket")]
public class Ticket : BaseEntity
{   
    public double Price { get; set; }
    public string Recipient { get; set; }

    public int MovieId { get; set; }
    public Movie Movie { get; set; }

    public RoomCoordinate RoomCoordinate { get; set; }
    public int RoomCoordinateId { get; set; }
}
