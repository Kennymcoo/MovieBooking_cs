using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories;

internal class RolesRepository : BaseRepository<Role>, IRolesRepository
{

    public RolesRepository(SqlConnection con) : base(con)
    {
    }


}
