using MovieDB.Domain.Entities.Base;

namespace MovieDB.Domain.Entities
{
    public class ExternalIds : BaseEntity
    {
        public Media Media { get; set; } = default!;
        public string MediaId { get; set; } = default!;
        public string? Imdb { get; set; }
        public string? Tvdb { get; set; }
        public string? Moviedb { get; set; }
        public string? Rottentomatoes { get; set; }
        public string? Metacritic { get; set; }
    }
}