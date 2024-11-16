using MovieDB.Domain.Entities;
using MovieDB.Infrastructure.Data;

namespace MovieDB.Api.Nodes;

[Node]
[ExtendObjectType(typeof(Certification))]
public class CertificationNode
{
    [ID] public required string Id { get; set; }
    
    public ValueTask<Certification?> GetCertificationAsync(string id, ApplicationDbContext dbContext)
    {
        return dbContext.Certifications.FindAsync(id);
    }
}