using MovieDB.Domain.Entities.Base;

namespace MovieDB.Domain.Entities
{
    public class Keyword : BaseEntity
    {
        public string Name { get; set; } = default!;
        public ICollection<Media> Media { get; set; } = new List<Media>();
    }
}
