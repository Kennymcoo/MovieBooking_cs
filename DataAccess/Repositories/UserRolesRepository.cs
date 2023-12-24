namespace DataAccess.Repositories;

public class UserRolesRepository : BaseRepository<UserRole>, IUserRolesRepository
{
    public UserRolesRepository(SqlConnection con) : base(con)
    {
    }

}
