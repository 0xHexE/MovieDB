using MovieDB.Domain.Entities;
using MovieDB.Infrastructure.Data;

namespace MovieDB.Api.Types;

[QueryType]
public static class Query
{
    public static string Version()
    {
        return "1.0";
    }

    [UsePaging]
    public static IQueryable<Media> GetMovies(ApplicationDbContext dbContext)
    {
        return dbContext.Media;
    }
}
