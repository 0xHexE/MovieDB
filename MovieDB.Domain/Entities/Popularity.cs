using MovieDB.Domain.Entities.Base;

namespace MovieDB.Domain.Entities;

public class Popularity : BaseEntity
{
    public Media Media { get; set; } = default!;
    public string MediaId { get; set; } = default!;
    public float? Moviedb { get; set; }
    public float? Stremio { get; set; }
    public float? StremioLib { get; set; }
    public float? Trakt { get; set; }
}