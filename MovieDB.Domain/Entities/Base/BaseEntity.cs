namespace MovieDB.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        public string Id { get; set; } = default!;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
