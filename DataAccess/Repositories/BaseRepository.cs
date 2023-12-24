using Dapper.Contrib.Extensions;
using DataAccess.Abstracts;
using Models.Entities;

namespace DataAccess.Repositories;


public class BaseRepository<Entity> : IBaseRepository<Entity> where Entity : BaseEntity
{
    private readonly SqlConnection _con;
    private readonly string _tableName;

    public BaseRepository(SqlConnection con)
    {
        _con = con;

        Type type = typeof(Entity);
        _tableName = type switch
        {
            Type _ when type == typeof(Movie) => "movie",
            Type _ when type == typeof(MovieSession) => "movieSession",
            Type _ when type == typeof(Role) => "role",
            Type _ when type == typeof(RoomCoordinate) => "roomCoordinate",
            Type _ when type == typeof(Room) => "room",
            Type _ when type == typeof(Session) => "session",
            Type _ when type == typeof(Ticket) => "ticket",
            Type _ when type == typeof(UserRole) => "userRole",
            Type _ when type == typeof(User) => "user",
            _ => "",
        };
    }

    public void Create(Entity entity)
    {        
        _con.Insert(entity);
    }
    

    public List<Entity> GetAll()
    {        
        return _con.Query<Entity>($"SELECT * FROM {_tableName}").ToList();
    }

    public Entity GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(Entity entity)
    {
        _con.Update(entity);
    }
        
    public void Delete(Entity entity)
    {
        string deleteQuery = $"DELETE FROM {_tableName} WHERE id = @Id";
        var result = _con.Execute(deleteQuery,entity);
    }


}
