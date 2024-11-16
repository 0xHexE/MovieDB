using MovieDB.Domain.Entities;
using MovieDB.Infrastructure.Data;

namespace MovieDB.Api.Nodes;

[Node]
[ExtendObjectType(typeof(ReviewedBy))]
public class ReviewedByNode
{
    [ID] public required string Id { get; set; }
    
    
    public ValueTask<ReviewedBy?> GetReviewedByAsync(string id, ApplicationDbContext dbContext)
    {
        return dbContext.Reviews.FindAsync(id);
    }
};