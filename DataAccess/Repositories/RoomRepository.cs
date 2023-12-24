namespace DataAccess.Repositories;

internal class RoomRepository : BaseRepository<Room>, IRoomRepository
{
    private readonly SqlConnection _con;

    public RoomRepository(SqlConnection con) : base(con)
    {
        _con = con;
    }        
}
