using Microsoft.EntityFrameworkCore;
using MovieDB.Domain.Entities;

namespace MovieDB.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Media> Media => Set<Media>();
        public DbSet<Season> Seasons => Set<Season>();
        
        public DbSet<Episode> Episodes => Set<Episode>();
        public DbSet<Person> People => Set<Person>();
        public DbSet<CastMember> CastMembers => Set<CastMember>();
        public DbSet<CrewMember> CrewMembers => Set<CrewMember>();
        public DbSet<Genre> Genres => Set<Genre>();
        public DbSet<Keyword> Keywords => Set<Keyword>();
        public DbSet<Award> Awards => Set<Award>();
        public DbSet<Trailer> Trailers => Set<Trailer>();
        public DbSet<Popularity> Popularities => Set<Popularity>();
        public DbSet<ExternalIds> ExternalIds => Set<ExternalIds>();
        public DbSet<PersonExternalIds> PersonExternalIds => Set<PersonExternalIds>();
        public DbSet<ProductionCompany> ProductionCompanies => Set<ProductionCompany>();
        public DbSet<Certification> Certifications => Set<Certification>();
        public DbSet<ReviewedBy> Reviews => Set<ReviewedBy>();
        public DbSet<Like> Likes => Set<Like>();
        public DbSet<Comment> Comments => Set<Comment>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
