using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieDB.Domain.Entities;

namespace MovieDB.Infrastructure.Data.Configurations;

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(e => e.BirthName)
            .HasMaxLength(255);

        builder.Property(e => e.Biography)
            .HasColumnType("text");

        builder.HasOne(e => e.ExternalIds)
            .WithOne(e => e.Person)
            .HasForeignKey<PersonExternalIds>(e => e.PersonId);
    }
}