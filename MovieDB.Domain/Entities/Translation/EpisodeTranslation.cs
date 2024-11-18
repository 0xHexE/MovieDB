using MovieDB.Domain.Entities.Base;

namespace MovieDB.Domain.Entities.Translation;

public class EpisodeTranslation : BaseEntity
{
    public string EpisodeId { get; set; } = default!;
    public Episode Episode { get; set; } = default!;
    public string LanguageCode { get; set; } = default!;
    public string Title { get; set; } = default!;
    public string? Overview { get; set; }
    public string? Plot { get; set; }
    public string? Filming { get; set; }
}
