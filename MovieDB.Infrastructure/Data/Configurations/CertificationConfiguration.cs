using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieDB.Domain.Entities;

namespace MovieDB.Infrastructure.Data.Configurations;

public class CertificationConfiguration : IEntityTypeConfiguration<Certification>
{
    public void Configure(EntityTypeBuilder<Certification> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Country)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(e => e.Rating)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasMany(e => e.Media)
            .WithMany(e => e.Certification)
            .UsingEntity(j => j.ToTable("MediaCertifications"));

        builder.HasMany(e => e.Seasons)
            .WithMany(e => e.Certification)
            .UsingEntity(j => j.ToTable("SeasonCertifications"));

        builder.HasMany(e => e.Episodes)
            .WithMany(e => e.Certification)
            .UsingEntity(j => j.ToTable("EpisodeCertifications"));
    }
}