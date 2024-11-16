using MovieDB.Domain.Entities;
using MovieDB.Infrastructure.Data;

namespace MovieDB.Api.Nodes;

[Node]
[ExtendObjectType(typeof(Media))]
public class MediaNode
{
    [ID] public required string Id { get; set; }
    
    
    public ValueTask<Media?> GetMediaAsync(string id, ApplicationDbContext dbContext)
    {
        return dbContext.Media.FindAsync(id);
    }
};