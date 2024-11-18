using MovieDB.Domain.Entities.Base;

namespace MovieDB.Domain.Entities.Translation;

public class MediaTranslation : BaseEntity
{
    public string MediaId { get; set; } = default!;
    public Media Media { get; set; } = default!;
    public string LanguageCode { get; set; } = default!;
    public string Title { get; set; } = default!;
    public string? Description { get; set; }
    public string? Tagline { get; set; }
    public string? Plot { get; set; }
    public string? Filming { get; set; }
}
