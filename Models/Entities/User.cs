namespace Models.Entities;

[Table("user")]
public class User : BaseEntity
{
    public string FullName { get; set; }
    public string Email { get; set; }
}
