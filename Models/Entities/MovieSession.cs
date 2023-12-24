namespace Models.Entities;

[Table("movieSession")]
public class MovieSession : BaseEntity
{ 

    public int MovieId { get; set; }
    public Movie Movie { get; set; }

    public int SessionId { get; set; }
    public Session Session { get; set; }
}
