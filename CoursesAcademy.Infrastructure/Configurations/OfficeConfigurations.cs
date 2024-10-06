using CoursesAcademy.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesAcademy.Infrastructure.Configurations
{
    public class OfficeConfigurations : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {

            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.OfficeLocation)
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(e => e.OfficeName)
                .HasMaxLength(50)
                .IsUnicode(false);

        }
    }
}
