using System;
using System.Collections.Generic;

namespace CoursesAcademy.Data.Entities;

public partial class Individual
{
    public int Id { get; set; }

    public string University { get; set; } = null!;

    public int YearOfGraduation { get; set; }

    public bool IsIntern { get; set; }

    public virtual Particpant IdNavigation { get; set; } = null!;
}
