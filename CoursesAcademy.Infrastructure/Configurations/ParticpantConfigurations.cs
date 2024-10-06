using CoursesAcademy.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoursesAcademy.Infrastructure.Configurations
{
    public class ParticpantConfigurations : IEntityTypeConfiguration<Particpant>
    {
        public void Configure(EntityTypeBuilder<Particpant> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.NameAr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FName");
            builder.Property(e => e.NameEn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LName");
        }
    }
}
