namespace DataAccess.Abstracts;

public interface IUnitOfWork
{
    public IMovieRepository MovieRepository { get; }
    public IMovieSessionRepository MovieSessionRepository { get; }
    public IRolesRepository RolesRepository { get; }
    public IRoomCoordinateRepository RoomCoordinateRepository { get; }
    public IRoomRepository RoomRepository { get; }
    public ISessionRepository SessionRepository { get; }
    public ITicketRepository TicketRepository { get; }
    public IUserRepository UserRepository { get; }
    public IUserRolesRepository UserRolesRepository { get; }    
}
