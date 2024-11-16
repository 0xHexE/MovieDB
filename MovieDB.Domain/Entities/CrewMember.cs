using MovieDB.Domain.Entities.Base;

namespace MovieDB.Domain.Entities
{
    public class CrewMember : BaseEntity
    {
        public Person Person { get; set; } = default!;
        public string PersonId { get; set; } = default!;
        public Media Media { get; set; } = default!;
        public string MediaId { get; set; } = default!;
        public string Job { get; set; } = default!;
        public string Department { get; set; } = default!;
        public Episode? Episode { get; set; }
        public string? EpisodeId { get; set; }
    }
}
