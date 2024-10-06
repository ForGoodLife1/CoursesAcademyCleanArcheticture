namespace CoursesAcademy.Data.Entities;

public partial class Instructor
{
    public int Id { get; set; }

    public string NameAr { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public int OfficeId { get; set; }

    public virtual Office Office { get; set; } = null!;

    public virtual ICollection<Section> Sections { get; set; } = new List<Section>();
}
