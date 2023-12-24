namespace DataAccess.Repositories;

internal class MovieSessionRepository : BaseRepository<MovieSession>, IMovieSessionRepository
{
    public MovieSessionRepository(SqlConnection con) : base(con)
    {
    }
}
