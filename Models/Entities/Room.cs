namespace Models.Entities;

[Table("room")]
public class Room : BaseEntity
{  
    public string Name { get; set; }
}
