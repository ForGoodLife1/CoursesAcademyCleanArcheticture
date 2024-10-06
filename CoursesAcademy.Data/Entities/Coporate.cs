using System;
using System.Collections.Generic;


namespace CoursesAcademy.Data.Entities;
public partial class Coporate
{
    public int Id { get; set; }

    public string Company { get; set; } = null!;

    public string JobTitle { get; set; } = null!;

    public virtual Particpant IdNavigation { get; set; } = null!;
}
