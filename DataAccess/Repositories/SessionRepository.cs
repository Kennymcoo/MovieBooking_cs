namespace DataAccess.Repositories;
public class SessionRepository : BaseRepository<Session>, ISessionRepository
{
    public SessionRepository(SqlConnection con) : base(con)
    {
    }

}
