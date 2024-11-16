using MovieDB.Domain.Entities.Base;
using MovieDB.Domain.Entities.Enums;
using MovieDB.Domain.Entities.Translation;

namespace MovieDB.Domain.Entities;

public class Media : BaseEntity
{
    public string ImdbId { get; set; } = default!;
    public int? TvdbId { get; set; }
    public int? MoviedbId { get; set; }
    
    public string Title { get; set; } = default!;
    public string? OriginalTitle { get; set; }
    public MediaType Type { get; set; }
    public string Slug { get; set; } = default!;
    public string? Description { get; set; }
    public string? Year { get; set; }
    public DateTime? Released { get; set; }
    public string? Runtime { get; set; }
    public string? Status { get; set; }
    public string? Rated { get; set; }
    public ICollection<MediaTranslation> Translations { get; set; } = new List<MediaTranslation>();
    public string[] Language { get; set; } = [];
    public string[] Country { get; set; } = [];
    public ICollection<Genre> Genres { get; set; } = new List<Genre>();
    public ICollection<Keyword> Keywords { get; set; } = new List<Keyword>();
    public float? ImdbRating { get; set; }
    public int? ImdbVotes { get; set; }
    public int? Metascore { get; set; }
    public int? RottenTomatoes { get; set; }
    public Popularity? Popularities { get; set; }
    public string? Poster { get; set; }
    public string? Background { get; set; }
    public string? Logo { get; set; }
    public ICollection<CastMember> Cast { get; set; } = new List<CastMember>();
    public ICollection<CrewMember> Crew { get; set; } = new List<CrewMember>();
    public float? Budget { get; set; }
    public float? BoxOffice { get; set; }
    public ICollection<Award> Awards { get; set; } = new List<Award>();
    public ICollection<Trailer> Trailers { get; set; } = new List<Trailer>();
    public ICollection<Season> Seasons { get; set; } = new List<Season>();
    public int? TotalSeasons { get; set; }
    public ExternalIds? ExternalIds { get; set; }
    public ICollection<ProductionCompany> ProductionCompanies { get; set; } = new List<ProductionCompany>();
    public ICollection<Certification> Certification { get; set; } = new List<Certification>();
    public string? Homepage { get; set; }
    public string? Tagline { get; set; }
    public int? VoteCount { get; set; }
    public string[] SpokenLanguages { get; set; } = [];
    public ICollection<ReviewedBy> ReviewedBy { get; set; } = new List<ReviewedBy>();
    public ICollection<Like> Likes { get; set; } = new List<Like>();
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
}