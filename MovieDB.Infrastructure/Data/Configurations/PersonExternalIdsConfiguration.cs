using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieDB.Domain.Entities;

namespace MovieDB.Infrastructure.Data.Configurations;

public class PersonExternalIdsConfiguration : IEntityTypeConfiguration<PersonExternalIds>
{
    public void Configure(EntityTypeBuilder<PersonExternalIds> builder)
    {
        builder.HasKey(e => e.Id);

        builder.HasOne(e => e.Person)
            .WithOne(e => e.ExternalIds)
            .HasForeignKey<PersonExternalIds>(e => e.PersonId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(e => e.PersonId)
            .IsUnique();

        builder.Property(e => e.Imdb)
            .HasMaxLength(50);

        builder.Property(e => e.Tvdb)
            .HasMaxLength(50);

        builder.Property(e => e.Moviedb)
            .HasMaxLength(50);
    }
}