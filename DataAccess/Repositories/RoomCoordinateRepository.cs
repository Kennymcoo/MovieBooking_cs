﻿using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories;

internal class RoomCoordinateRepository : BaseRepository<RoomCoordinate>, IRoomCoordinateRepository
{
    public RoomCoordinateRepository(SqlConnection con) : base(con)
    {
    }

}
