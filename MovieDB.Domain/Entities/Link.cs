using MovieDB.Domain.Entities.Base;

namespace MovieDB.Domain.Entities;

public class Link : BaseEntity
{
    public string Title { get; set; }
    public string Location { get; set; }
    public string MediaId { get; set; }
    public Media Media { get; set; } = null!;
}
