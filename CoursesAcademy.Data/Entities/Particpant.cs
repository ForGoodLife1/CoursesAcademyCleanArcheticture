namespace CoursesAcademy.Data.Entities;

public partial class Particpant
{
    public int Id { get; set; }

    public string NameAr { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public virtual Coporate? Coporate { get; set; }

    public virtual Individual? Individual { get; set; }

    public virtual ICollection<Section> Sections { get; set; } = new List<Section>();
}
