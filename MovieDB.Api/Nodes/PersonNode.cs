using MovieDB.Domain.Entities;
using MovieDB.Infrastructure.Data;

namespace MovieDB.Api.Nodes;

[Node]
[ExtendObjectType(typeof(Person))]
public class PersonNode
{
    [ID] public required string Id { get; set; }
    
    
    public ValueTask<Person?> GetPersonAsync(string id, ApplicationDbContext dbContext)
    {
        return dbContext.People.FindAsync(id);
    }
};