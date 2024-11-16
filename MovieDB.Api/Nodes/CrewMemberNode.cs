using MovieDB.Domain.Entities;
using MovieDB.Infrastructure.Data;

namespace MovieDB.Api.Nodes;

[Node]
[ExtendObjectType(typeof(CrewMember))]
public class CrewMemberNode
{
    [ID] public required string Id { get; set; }
    
    public ValueTask<CrewMember?> GetCrewMemberAsync(string id, ApplicationDbContext dbContext)
    {
        return dbContext.CrewMembers.FindAsync(id);
    }
}
