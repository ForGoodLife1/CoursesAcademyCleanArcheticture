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
    public class ScheduleConfigurations : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
           builder.Property(e => e.Id).ValueGeneratedNever();
           builder.Property(e => e.Fri).HasColumnName("FRI");
           builder.Property(e => e.Mon).HasColumnName("MON");
           builder.Property(e => e.Sat).HasColumnName("SAT");
           builder.Property(e => e.Sun).HasColumnName("SUN");
           builder.Property(e => e.Thu).HasColumnName("THU");
           builder.Property(e => e.Tue).HasColumnName("TUE");
            builder.Property(e => e.Wed).HasColumnName("WED");
        }
    }
}
