using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieDB.Domain.Entities;

namespace MovieDB.Infrastructure.Data.Configurations;

public class SeasonConfiguration : IEntityTypeConfiguration<Season>
{
    public void Configure(EntityTypeBuilder<Season> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Title)
            .HasMaxLength(255);

        builder.Property(e => e.Overview)
            .HasColumnType("text");

        builder.HasOne(e => e.Media)
            .WithMany(e => e.Seasons)
            .HasForeignKey(e => e.MediaId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(e => e.ProductionCompanies)
            .WithMany(e => e.Seasons)
            .UsingEntity(j => j.ToTable("SeasonProductionCompanies"));

        builder.HasMany(e => e.Certification)
            .WithMany(e => e.Seasons)
            .UsingEntity(j => j.ToTable("SeasonCertifications"));
    }
}
