namespace MovieDB.Infrastructure.Data.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieDB.Domain.Entities;

public class EpisodeConfiguration : IEntityTypeConfiguration<Episode>
{
    public void Configure(EntityTypeBuilder<Episode> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Title)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(e => e.Overview)
            .HasColumnType("text");

        builder.HasOne(e => e.Season)
            .WithMany(e => e.Episodes)
            .HasForeignKey(e => e.SeasonId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(e => e.ProductionCompanies)
            .WithMany(e => e.Episodes)
            .UsingEntity(j => j.ToTable("EpisodeProductionCompanies"));

        builder.HasMany(e => e.Certification)
            .WithMany(e => e.Episodes)
            .UsingEntity(j => j.ToTable("EpisodeCertifications"));
    }
}