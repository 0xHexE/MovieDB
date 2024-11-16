using MovieDB.Domain.Entities;
using MovieDB.Infrastructure.Data;

namespace MovieDB.Api.Nodes;

[Node]
[ExtendObjectType(typeof(PersonExternalIds))]
public abstract class PersonExternalIdsExtension
{
    [ID] public required string Id { get; set; }
    
    public ValueTask<PersonExternalIds?> GetPersonExternalIdsAsync(string id, ApplicationDbContext dbContext)
    {
        return dbContext.PersonExternalIds.FindAsync(id);
    }
};