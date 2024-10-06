using System;
using System.Collections.Generic;

namespace CoursesAcademy.Data.Entities;

public partial class Course
{
    public int Id { get; set; }

    public string CourseName { get; set; } = null!;

    public decimal Price { get; set; }

    public int HoursToComplete { get; set; }

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual ICollection<Section> Sections { get; set; } = new List<Section>();
}
