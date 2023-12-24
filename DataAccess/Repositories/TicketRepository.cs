namespace DataAccess.Repositories;

public class TicketRepository : BaseRepository<Ticket>, ITicketRepository
{
    public TicketRepository(SqlConnection con) : base(con)
    {
    }

}
