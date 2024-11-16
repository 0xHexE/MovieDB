using MovieDB.Domain.Entities;
using MovieDB.Infrastructure.Data;

namespace MovieDB.Api.Nodes;

[Node]
[ExtendObjectType(typeof(ExternalIds))]
public class ExternalIdsNode
{
    [ID] public required string Id { get; set; }
    
    
    public ValueTask<ExternalIds?> GetExternalIdsAsync(string id, ApplicationDbContext dbContext)
    {
        return dbContext.ExternalIds.FindAsync(id);
    }
};