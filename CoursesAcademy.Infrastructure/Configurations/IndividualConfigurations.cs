using CoursesAcademy.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CoursesAcademy.Infrastructure.Configurations
{
    public class IndividualConfigurations : IEntityTypeConfiguration<Individual>
    {
        public void Configure(EntityTypeBuilder<Individual> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.HasOne(d => d.IdNavigation).WithOne(p => p.Individual).HasForeignKey<Individual>(d => d.Id);
        }
    }
}
