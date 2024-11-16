using MovieDB.Domain.Entities;
using MovieDB.Infrastructure.Data;

namespace MovieDB.Api.Nodes;

[Node]
[ExtendObjectType(typeof(Popularity))]
public class PopularityNode
{
    [ID] public required string Id { get; set; }
    
    
    public ValueTask<Popularity?> GetPopularityAsync(string id, ApplicationDbContext dbContext)
    {
        return dbContext.Popularities.FindAsync(id);
    }
};