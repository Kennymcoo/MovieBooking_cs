namespace Models.Entities;

[Table("session")]
public class Session : BaseEntity
{   
    public string Time { get; set; }

    public int RoomId { get; set; }
    public Room Room { get; set; }
}
