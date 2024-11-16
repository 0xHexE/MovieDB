using MovieDB.Domain.Entities.Base;

namespace MovieDB.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public Media? Media { get; set; }
        public Season? Season { get; set; }
        public Episode? Episode { get; set; }
        public Person? Person { get; set; }
        public string Content { get; set; } = default!;
    }
}