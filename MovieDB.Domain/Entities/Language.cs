using MovieDB.Domain.Entities.Base;

namespace MovieDB.Domain.Entities;

public class Language : BaseEntity
{
    public string Code { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string NativeName { get; set; } = default!;
    public bool IsActive { get; set; } = true;
    public bool IsDefault { get; set; }
}
