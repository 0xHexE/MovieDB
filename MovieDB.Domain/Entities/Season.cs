using MovieDB.Domain.Entities.Base;

namespace MovieDB.Domain.Entities;

public class Season : BaseEntity
{
    public int SeasonNumber { get; set; }
    public string? Title { get; set; }
    public string? Overview { get; set; }
    public DateTime? AirDate { get; set; }
    public ICollection<Episode> Episodes { get; set; } = new List<Episode>();
    public Media Media { get; set; } = default!;
    public string MediaId { get; set; } = default!;
    public string? Poster { get; set; }
    public ICollection<ProductionCompany> ProductionCompanies { get; set; } = new List<ProductionCompany>();
    public ICollection<Certification> Certification { get; set; } = new List<Certification>();
    public ICollection<Like> Likes { get; set; } = new List<Like>();
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
}