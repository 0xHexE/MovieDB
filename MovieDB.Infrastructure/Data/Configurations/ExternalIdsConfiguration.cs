using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieDB.Domain.Entities;

namespace MovieDB.Infrastructure.Data.Configurations;

public class ExternalIdsConfiguration : IEntityTypeConfiguration<ExternalIds>
{
    public void Configure(EntityTypeBuilder<ExternalIds> builder)
    {
        builder.HasKey(e => e.Id);

        builder.HasOne(e => e.Media)
            .WithOne(e => e.ExternalIds)
            .HasForeignKey<ExternalIds>(e => e.MediaId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(e => e.MediaId)
            .IsUnique();

        builder.Property(e => e.Imdb)
            .HasMaxLength(50);

        builder.Property(e => e.Tvdb)
            .HasMaxLength(50);

        builder.Property(e => e.Moviedb)
            .HasMaxLength(50);

        builder.Property(e => e.Rottentomatoes)
            .HasMaxLength(50);

        builder.Property(e => e.Metacritic)
            .HasMaxLength(50);
    }
}