using System;
using System.Collections.Generic;

namespace CoursesAcademy.Data.Entities;

public partial class Schedule
{
    public int Id { get; set; }

    public string ScheduleType { get; set; } = null!;

    public bool Sun { get; set; }

    public bool Mon { get; set; }

    public bool Tue { get; set; }

    public bool Wed { get; set; }

    public bool Thu { get; set; }

    public bool Fri { get; set; }

    public bool Sat { get; set; }

    public virtual ICollection<Section> Sections { get; set; } = new List<Section>();
}
