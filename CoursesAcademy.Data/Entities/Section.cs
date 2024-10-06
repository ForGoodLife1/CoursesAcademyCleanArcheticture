namespace CoursesAcademy.Data.Entities;

public partial class Section
{
    public int Id { get; set; }

    public string SectionNameAr { get; set; } = null!;
    public string SectionNameEn { get; set; } = null!;

    public int CourseId { get; set; }

    public int InstructorId { get; set; }

    public int ScheduleId { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual Instructor Instructor { get; set; } = null!;

    public virtual Schedule Schedule { get; set; } = null!;

    public virtual ICollection<Particpant> Participants { get; set; } = new List<Particpant>();
}
