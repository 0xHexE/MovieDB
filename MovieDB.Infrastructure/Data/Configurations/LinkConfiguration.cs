using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieDB.Domain.Entities;

namespace MovieDB.Infrastructure.Data.Configurations;

public class LinkConfiguration : IEntityTypeConfiguration<Link>
{
    public void Configure(EntityTypeBuilder<Link> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Title).
            IsRequired();
        builder.Property(x => x.Location).IsRequired();
        builder.HasOne<Media>()
            .WithMany(m => m.Links)
            .HasForeignKey("MediaId")
            .OnDelete(DeleteBehavior.Cascade);
    }
}