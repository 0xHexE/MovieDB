using MovieDB.Domain.Entities;
using MovieDB.Infrastructure.Data;

namespace MovieDB.Api.Nodes;

[Node]
[ExtendObjectType(typeof(Genre))]
public class GenreExtension
{
    [ID] public required string Id { get; set; }
    
    
    public ValueTask<Genre?> GetGenreAsync(string id, ApplicationDbContext dbContext)
    {
        return dbContext.Genres.FindAsync(id);
    }
};