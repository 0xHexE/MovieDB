using MovieDB.Domain.Entities.Base;

namespace MovieDB.Domain.Entities.Translation;

public class SeasonTranslation : BaseEntity
{
    public string SeasonId { get; set; } = default!;
    public Season Season { get; set; } = default!;
    public string LanguageCode { get; set; } = default!;
    public string? Title { get; set; }
    public string? Overview { get; set; }
    public string? Plot { get; set; }
    public string? Filming { get; set; }
}