using CoursesAcademy.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoursesAcademy.Infrastructure.Configurations
{
    public class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasIndex(e => e.OfficeId, "IX_Instructors_OfficeId").IsUnique();

            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.NameAr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FName");
            builder.Property(e => e.NameEn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LName");

            builder.HasOne(d => d.Office).WithOne(p => p.Instructor)
                .HasForeignKey<Instructor>(d => d.OfficeId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
