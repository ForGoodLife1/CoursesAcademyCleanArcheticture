using System;
using System.Collections.Generic;

namespace CoursesAcademy.Data.Entities;

public partial class Office
{
    public int Id { get; set; }

    public string OfficeName { get; set; } = null!;

    public string OfficeLocation { get; set; } = null!;

    public virtual Instructor? Instructor { get; set; }
}
