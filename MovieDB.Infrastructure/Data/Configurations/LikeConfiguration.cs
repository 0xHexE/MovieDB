using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieDB.Domain.Entities;

namespace MovieDB.Infrastructure.Data.Configurations;

public class LikeConfiguration : IEntityTypeConfiguration<Like>
{
    public void Configure(EntityTypeBuilder<Like> builder)
    {
        builder.HasKey(e => e.Id);

        builder.HasOne(e => e.Media)
            .WithMany(e => e.Likes)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(e => e.Season)
            .WithMany(e => e.Likes)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(e => e.Episode)
            .WithMany(e => e.Likes)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(e => e.Person)
            .WithMany(e => e.Likes)
            .OnDelete(DeleteBehavior.SetNull);
    }
}