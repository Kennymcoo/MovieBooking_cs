namespace DataAccess;

public class UnitOfWork : IUnitOfWork
{
    private readonly SqlConnection _sqlConnection;

    public UnitOfWork()
    {
        DataAccessManager dataAccessManager = new();
        _sqlConnection = dataAccessManager.Connection;
    }
     
    public IMovieRepository MovieRepository => new MovieRepository(_sqlConnection);
    public IMovieSessionRepository MovieSessionRepository => new MovieSessionRepository(_sqlConnection);
    public IRolesRepository RolesRepository => new RolesRepository(_sqlConnection);
    public IRoomCoordinateRepository RoomCoordinateRepository => new RoomCoordinateRepository(_sqlConnection);
    public IRoomRepository RoomRepository => new RoomRepository(_sqlConnection);
    public ISessionRepository SessionRepository => new SessionRepository(_sqlConnection);
    public ITicketRepository TicketRepository => new TicketRepository(_sqlConnection);
    public IUserRepository UserRepository => new UserRepository(_sqlConnection);
    public IUserRolesRepository UserRolesRepository => new UserRolesRepository(_sqlConnection);        
}
