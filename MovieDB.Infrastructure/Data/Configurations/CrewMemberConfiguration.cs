using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieDB.Domain.Entities;

namespace MovieDB.Infrastructure.Data.Configurations;

public class CrewMemberConfiguration : IEntityTypeConfiguration<CrewMember>
{
    public void Configure(EntityTypeBuilder<CrewMember> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Job)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(e => e.Department)
            .IsRequired()
            .HasMaxLength(255);

        builder.HasOne(e => e.Person)
            .WithMany(e => e.CrewRoles)
            .HasForeignKey(e => e.PersonId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(e => e.Media)
            .WithMany(e => e.Crew)
            .HasForeignKey(e => e.MediaId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(e => e.Episode)
            .WithMany(e => e.Crew)
            .HasForeignKey(e => e.EpisodeId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}