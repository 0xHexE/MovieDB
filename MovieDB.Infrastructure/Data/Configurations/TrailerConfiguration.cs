using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieDB.Domain.Entities;

namespace MovieDB.Infrastructure.Data.Configurations;

public class TrailerConfiguration : IEntityTypeConfiguration<Trailer>
{
    public void Configure(EntityTypeBuilder<Trailer> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Source)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(e => e.Type)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(e => e.Title)
            .HasMaxLength(255);

        builder.Property(e => e.Language)
            .HasMaxLength(50);

        builder.HasOne(e => e.Media)
            .WithMany(e => e.Trailers)
            .HasForeignKey(e => e.MediaId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}