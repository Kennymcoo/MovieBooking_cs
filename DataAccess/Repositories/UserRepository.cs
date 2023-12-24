using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories;

internal  class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(SqlConnection con) : base(con)
    {
    }

    
}
