using CoursesAcademy.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoursesAcademy.Infrastructure.Configurations
{
    public class CoporateConfigurations : IEntityTypeConfiguration<Coporate>
    {
        public void Configure(EntityTypeBuilder<Coporate> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.HasOne(d => d.IdNavigation).WithOne(p => p.Coporate).HasForeignKey<Coporate>(d => d.Id);
        }
    }
}
