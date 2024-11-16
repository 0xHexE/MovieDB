using MovieDB.Domain.Entities;
using MovieDB.Infrastructure.Data;

namespace MovieDB.Api.Nodes;

[Node]
[ExtendObjectType(typeof(Award))]
public class AwardNode
{
    public required string Id { get; set; }
    
    public ValueTask<Award?> GetAwardAsync(string id, ApplicationDbContext dbContext)
    {
        return dbContext.Awards.FindAsync(id);
    }
}