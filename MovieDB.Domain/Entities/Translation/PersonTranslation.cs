using MovieDB.Domain.Entities.Base;

namespace MovieDB.Domain.Entities.Translation;

public class PersonTranslation : BaseEntity
{
    public string PersonId { get; set; } = default!;
    public Person Person { get; set; } = default!;
    public string LanguageCode { get; set; } = default!;
    public string? Biography { get; set; }
}