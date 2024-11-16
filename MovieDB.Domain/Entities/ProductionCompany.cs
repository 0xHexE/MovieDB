using MovieDB.Domain.Entities.Base;

namespace MovieDB.Domain.Entities;

public class ProductionCompany : BaseEntity
{
    public string Name { get; set; } = default!;
    public string? Logo { get; set; }
    public string? OriginCountry { get; set; }
    public ICollection<Media> Media { get; set; } = new List<Media>();
    public ICollection<Season> Seasons { get; set; } = new List<Season>();
    public ICollection<Episode> Episodes { get; set; } = new List<Episode>();
}