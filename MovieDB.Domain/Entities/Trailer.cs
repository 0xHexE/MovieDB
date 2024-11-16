using MovieDB.Domain.Entities.Base;

namespace MovieDB.Domain.Entities;

public class Trailer : BaseEntity
{
    public Media Media { get; set; } = default!;
    public string MediaId { get; set; } = default!;
    public string Source { get; set; } = default!;
    public string Type { get; set; } = default!;
    public string? Title { get; set; }
    public string? Language { get; set; }
}