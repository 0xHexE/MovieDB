using MovieDB.Domain.Entities;
using MovieDB.Infrastructure.Data;

namespace MovieDB.Api.Nodes;

[Node]
[ExtendObjectType(typeof(ProductionCompany))]
public class ProductionCompanyNode
{
    [ID] public required string Id { get; set; }
    
    
    public ValueTask<ProductionCompany?> GetProductionCompanyAsync(string id, ApplicationDbContext dbContext)
    {
        return dbContext.ProductionCompanies.FindAsync(id);
    }
};