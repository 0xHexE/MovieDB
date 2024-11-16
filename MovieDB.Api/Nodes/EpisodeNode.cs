using MovieDB.Domain.Entities;
using MovieDB.Infrastructure.Data;

namespace MovieDB.Api.Nodes;

[Node]
[ExtendObjectType(typeof(Episode))]
public class EpisodeNode
{
    [ID] public required string Id { get; set; }
    
    
    public ValueTask<Episode?> GetEpisodeAsync(string id, ApplicationDbContext dbContext)
    {
        return dbContext.Episodes.FindAsync(id);
    }
};