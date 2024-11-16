using MovieDB.Domain.Entities.Base;

namespace MovieDB.Domain.Entities
{
    public class Episode : BaseEntity
    {
        public Season Season { get; set; } = default!;
        public string SeasonId { get; set; } = default!;
        public int EpisodeNumber { get; set; }
        public string Title { get; set; } = default!;
        public string? Overview { get; set; }
        public DateTime? AirDate { get; set; }
        public int? Runtime { get; set; }
        public string? Thumbnail { get; set; }
        public float? Rating { get; set; }
        public ICollection<CrewMember> Crew { get; set; } = new List<CrewMember>();
        public ICollection<CastMember> Cast { get; set; } = new List<CastMember>();
        public ICollection<ProductionCompany> ProductionCompanies { get; set; } = new List<ProductionCompany>();
        public ICollection<Certification> Certification { get; set; } = new List<Certification>();
        public ICollection<Like> Likes { get; set; } = new List<Like>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}