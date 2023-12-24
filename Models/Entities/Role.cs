namespace Models.Entities;

[Table("role")]
public class Role : BaseEntity
{
    public string Description { get; set; }
}
