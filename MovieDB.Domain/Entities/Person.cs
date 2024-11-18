using MovieDB.Domain.Entities.Base;

namespace MovieDB.Domain.Entities;

public class Person : BaseEntity
{
    public string Name { get; set; } = default!;
    public string? BirthName { get; set; }
    public DateTime? Birthday { get; set; }
    public DateTime? Deathday { get; set; }
    public string? Gender { get; set; }
    public string? Biography { get; set; }
    public string? BirthPlace { get; set; }
    public string? Photo { get; set; }
    public ICollection<CastMember> CastRoles { get; set; } = new List<CastMember>();
    public ICollection<CrewMember> CrewRoles { get; set; } = new List<CrewMember>();
    public float? Popularity { get; set; }
    public PersonExternalIds? ExternalIds { get; set; }
    public ICollection<Like> Likes { get; set; } = new List<Like>();
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
}