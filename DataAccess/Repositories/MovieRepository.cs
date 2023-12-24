using DataAccess.Abstracts;
using Models.Entities;

namespace DataAccess.Repositories;

//internal class MovieRepository : BaseRepository<Movie>
public class MovieRepository : BaseRepository<Movie>, IMovieRepository
{
    public MovieRepository(SqlConnection con) : base(con)
    {
    }
}
