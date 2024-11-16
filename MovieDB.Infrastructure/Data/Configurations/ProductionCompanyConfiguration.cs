using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieDB.Domain.Entities;

namespace MovieDB.Infrastructure.Data.Configurations;

public class ProductionCompanyConfiguration : IEntityTypeConfiguration<ProductionCompany>
{
    public void Configure(EntityTypeBuilder<ProductionCompany> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(e => e.Logo)
            .HasMaxLength(255);

        builder.Property(e => e.OriginCountry)
            .HasMaxLength(50);

        builder.HasMany(e => e.Media)
            .WithMany(e => e.ProductionCompanies)
            .UsingEntity(j => j.ToTable("MediaProductionCompanies"));

        builder.HasMany(e => e.Seasons)
            .WithMany(e => e.ProductionCompanies)
            .UsingEntity(j => j.ToTable("SeasonProductionCompanies"));

        builder.HasMany(e => e.Episodes)
            .WithMany(e => e.ProductionCompanies)
            .UsingEntity(j => j.ToTable("EpisodeProductionCompanies"));
    }
}