using MovieDB.Domain.Entities.Base;

namespace MovieDB.Domain.Entities;

public class PersonExternalIds : BaseEntity
{
    public Person Person { get; set; } = default!;
    public string PersonId { get; set; } = default!;
    public string? Imdb { get; set; }
    public string? Tvdb { get; set; }
    public string? Moviedb { get; set; }
}