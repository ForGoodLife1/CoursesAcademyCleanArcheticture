using CoursesAcademy.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CoursesAcademy.Infrastructure.Configurations
{
    public class SectionConfigurations : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.HasIndex(e => e.CourseId, "IX_Sections_CourseId");

            builder.HasIndex(e => e.InstructorId, "IX_Sections_InstructorId");

            builder.HasIndex(e => e.ScheduleId, "IX_Sections_ScheduleId");

            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.EndTime).HasPrecision(0);
            builder.Property(e => e.SectionNameAr)
                .HasMaxLength(255)
                .IsUnicode(false);
            builder.Property(e => e.SectionNameEn)
                .HasMaxLength(255)
                .IsUnicode(false);
            builder.Property(e => e.StartTime).HasPrecision(0);

            builder.HasOne(d => d.Course).WithMany(p => p.Sections).HasForeignKey(d => d.CourseId);

            builder.HasOne(d => d.Instructor).WithMany(p => p.Sections)
                .HasForeignKey(d => d.InstructorId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(d => d.Schedule).WithMany(p => p.Sections).HasForeignKey(d => d.ScheduleId);

            builder.HasMany(d => d.Participants).WithMany(p => p.Sections)
                .UsingEntity<Dictionary<string, object>>(
                    "Enrollment",
                    r => r.HasOne<Particpant>().WithMany().HasForeignKey("ParticipantId"),
                    l => l.HasOne<Section>().WithMany().HasForeignKey("SectionId"),
                    j =>
                    {
                        j.HasKey("SectionId", "ParticipantId");
                        j.ToTable("Enrollments");
                        j.HasIndex(new[] { "ParticipantId" }, "IX_Enrollments_ParticipantId");
                    });




        }
    }
}
