namespace Models.Entities;

[Table("roomCoordinate")]
public class RoomCoordinate : BaseEntity
{    
    public int RowIndex { get; set; }
    public int ColumnIndex { get; set; }

    public int RoomId { get; set; }
    public Room Room { get; set; }
}
