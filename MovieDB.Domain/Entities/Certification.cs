using MovieDB.Domain.Entities.Base;

namespace MovieDB.Domain.Entities
{
    public class Certification : BaseEntity
    {
        public string Country { get; set; } = default!;
        public string Rating { get; set; } = default!;
        public ICollection<Media> Media { get; set; } = new List<Media>();
        public ICollection<Season> Seasons { get; set; } = new List<Season>();
        public ICollection<Episode> Episodes { get; set; } = new List<Episode>();
    }
}
