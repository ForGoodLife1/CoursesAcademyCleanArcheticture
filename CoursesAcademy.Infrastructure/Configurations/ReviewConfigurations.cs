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
    public class ReviewConfigurations : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasIndex(e => e.CourseId, "IX_Reviews_CourseId");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.HasOne(d => d.Course).WithMany(p => p.Reviews).HasForeignKey(d => d.CourseId);
        }
    }
}
