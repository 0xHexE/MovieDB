using MovieDB.Domain.Entities.Base;

namespace MovieDB.Domain.Entities
{
    public class CastMember : BaseEntity
    {
        public Person Person { get; set; } = default!;
        public string PersonId { get; set; } = default!;
        public Media Media { get; set; } = default!;
        public string MediaId { get; set; } = default!;
        public string Character { get; set; } = default!;
        public int Order { get; set; }
        public Episode? Episode { get; set; }
        public string? EpisodeId { get; set; }
    }
}