using MovieDB.Domain.Entities;
using MovieDB.Infrastructure.Data;

namespace MovieDB.Api.Nodes;

[Node]
[ExtendObjectType(typeof(Trailer))]
public class TrailerNode
{
    [ID] public required string Id { get; set; }
    
    
    public ValueTask<Trailer?> GetTrailerAsync(string id, ApplicationDbContext dbContext)
    {
        return dbContext.Trailers.FindAsync(id);
    }
};