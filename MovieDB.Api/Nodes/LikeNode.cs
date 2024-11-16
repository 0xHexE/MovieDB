using MovieDB.Domain.Entities;
using MovieDB.Infrastructure.Data;

namespace MovieDB.Api.Nodes;

[Node]
[ExtendObjectType(typeof(Like))]
public class LikeNode
{
    [ID] public required string Id { get; set; }
    
    public ValueTask<Like?> GetLikeAsync(string id, ApplicationDbContext dbContext)
    {
        return dbContext.Likes.FindAsync(id);
    }
};