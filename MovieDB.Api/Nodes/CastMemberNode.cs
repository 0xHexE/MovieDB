using MovieDB.Domain.Entities;
using MovieDB.Infrastructure.Data;

namespace MovieDB.Api.Nodes;

[Node]
[ExtendObjectType(typeof(CastMember))]
public class CastMemberNode
{
    public required string Id { get; set; }
    
    public ValueTask<CastMember?> GetCastMemberAsync(string id, ApplicationDbContext dbContext)
    {
        return dbContext.CastMembers.FindAsync(id);
    }
};