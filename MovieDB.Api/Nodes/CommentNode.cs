using MovieDB.Domain.Entities;
using MovieDB.Infrastructure.Data;

namespace MovieDB.Api.Nodes;

[Node]
[ExtendObjectType(typeof(Comment))]
public class CommentNode
{
    [ID] public required string Id { get; set; }
    
    public ValueTask<Comment?> GetCommentAsync(string id, ApplicationDbContext dbContext)
    {
        return dbContext.Comments.FindAsync(id);
    }
}
