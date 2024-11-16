using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieDB.Domain.Entities;

namespace MovieDB.Infrastructure.Data.Configurations;

public class PopularityConfiguration : IEntityTypeConfiguration<Popularity>
{
    public void Configure(EntityTypeBuilder<Popularity> builder)
    {
        builder.HasKey(e => e.Id);

        builder.HasOne(e => e.Media)
            .WithOne(e => e.Popularities)
            .HasForeignKey<Popularity>(e => e.MediaId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(e => e.MediaId)
            .IsUnique();
    }
}