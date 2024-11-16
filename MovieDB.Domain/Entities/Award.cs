using MovieDB.Domain.Entities.Base;

namespace MovieDB.Domain.Entities
{
    public class Award : BaseEntity
    {
        public Media Media { get; set; } = default!;
        public string MediaId { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Category { get; set; } = default!;
        public int Year { get; set; }
        public bool IsWinner { get; set; }
        public string? Nominee { get; set; }
    }
}
