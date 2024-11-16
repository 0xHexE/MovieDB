using MovieDB.Domain.Entities;
using MovieDB.Infrastructure.Data;

namespace MovieDB.Api.Nodes;

[Node]
[ExtendObjectType(typeof(Season))]
public class SeasonNode
{
    [ID] public required string Id { get; set; }
    
    
    public ValueTask<Season?> GetSeasonAsync(string id, ApplicationDbContext dbContext)
    {
        return dbContext.Seasons.FindAsync(id);
    }
};