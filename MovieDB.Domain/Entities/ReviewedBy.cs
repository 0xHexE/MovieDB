using MovieDB.Domain.Entities.Base;

namespace MovieDB.Domain.Entities;

public class ReviewedBy : BaseEntity
{
    public Person Person { get; set; } = default!;
    public string PersonId { get; set; } = default!;
    public Media Media { get; set; } = default!;
    public string MediaId { get; set; } = default!;
    public float Rating { get; set; }
    public string? Review { get; set; }
}