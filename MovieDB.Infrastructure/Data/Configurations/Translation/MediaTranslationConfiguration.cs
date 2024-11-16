using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieDB.Domain.Entities.Translation;

namespace MovieDB.Infrastructure.Data.Configurations.Translation;

public class MediaTranslationConfiguration : IEntityTypeConfiguration<MediaTranslation>
{
    public void Configure(EntityTypeBuilder<MediaTranslation> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.LanguageCode)
            .IsRequired()
            .HasMaxLength(10);

        builder.Property(e => e.Title)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(e => e.Description)
            .HasColumnType("text");

        builder.Property(e => e.Tagline)
            .HasMaxLength(500);

        builder.HasOne(e => e.Media)
            .WithMany(e => e.Translations)
            .HasForeignKey(e => e.MediaId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(e => new { e.MediaId, e.LanguageCode }).IsUnique();
    }
}
