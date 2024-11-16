using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieDB.Domain.Entities;

namespace MovieDB.Infrastructure.Data.Configurations;

public class ReviewedByConfiguration : IEntityTypeConfiguration<ReviewedBy>
{
    public void Configure(EntityTypeBuilder<ReviewedBy> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Rating)
            .IsRequired();

        builder.Property(e => e.Review)
            .HasColumnType("text");

        builder.HasOne(e => e.Person)
            .WithMany(e => e.ReviewedBy)
            .HasForeignKey(e => e.PersonId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(e => e.Media)
            .WithMany(e => e.ReviewedBy)
            .HasForeignKey(e => e.MediaId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}