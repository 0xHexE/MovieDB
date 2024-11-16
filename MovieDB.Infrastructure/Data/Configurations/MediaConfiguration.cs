using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieDB.Domain.Entities;

namespace MovieDB.Infrastructure.Data.Configurations
{
    public class MediaConfiguration : IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.ImdbId)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(e => e.Slug)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(e => e.Description)
                .HasColumnType("text");

            builder.Property(e => e.Language)
                .HasColumnType("text[]");

            builder.Property(e => e.Country)
                .HasColumnType("text[]");

            builder.Property(e => e.SpokenLanguages)
                .HasColumnType("text[]");

            builder.HasIndex(e => e.ImdbId)
                .IsUnique();

            builder.HasIndex(e => e.Slug)
                .IsUnique();

            // Configure relationships
            builder.HasMany(e => e.Genres)
                .WithMany(e => e.Media)
                .UsingEntity(j => j.ToTable("MediaGenres"));

            builder.HasMany(e => e.Keywords)
                .WithMany(e => e.Media)
                .UsingEntity(j => j.ToTable("MediaKeywords"));

            builder.HasOne(e => e.Popularities)
                .WithOne(e => e.Media)
                .HasForeignKey<Popularity>(e => e.MediaId);

            builder.HasOne(e => e.ExternalIds)
                .WithOne(e => e.Media)
                .HasForeignKey<ExternalIds>(e => e.MediaId);
        }
    }
}