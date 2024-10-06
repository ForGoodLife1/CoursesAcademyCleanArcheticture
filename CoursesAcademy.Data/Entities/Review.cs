using System;
using System.Collections.Generic;

namespace CoursesAcademy.Data.Entities;

public partial class Review
{
    public int Id { get; set; }

    public string? Feedback { get; set; }

    public int CourseId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Course Course { get; set; } = null!;
}
