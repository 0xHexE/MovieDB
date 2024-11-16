using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieDB.Domain.Entities;

namespace MovieDB.Infrastructure.Data.Configurations;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Content)
            .IsRequired()
            .HasColumnType("text");

        builder.HasOne(e => e.Media)
            .WithMany(e => e.Comments)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(e => e.Season)
            .WithMany(e => e.Comments)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(e => e.Episode)
            .WithMany(e => e.Comments)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(e => e.Person)
            .WithMany(e => e.Comments)
            .OnDelete(DeleteBehavior.SetNull);
    }
}