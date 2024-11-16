using MovieDB.Domain.Entities;
using MovieDB.Infrastructure.Data;

namespace MovieDB.Api.Nodes;

[Node]
[ExtendObjectType(typeof(Keyword))]
public class KeywordNode
{
    [ID] public required string Id { get; set; }
    
    public ValueTask<Keyword?> GetKeywordAsync(string id, ApplicationDbContext dbContext)
    {
        return dbContext.Keywords.FindAsync(id);
    }
};