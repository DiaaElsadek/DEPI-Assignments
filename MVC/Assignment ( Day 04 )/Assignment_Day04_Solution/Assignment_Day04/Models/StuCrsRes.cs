using System.ComponentModel.DataAnnotations.Schema;

public class StuCrsRes
{
    public int StudentId { get; set; }
    public Student Student { get; set; }

    public int CourseId { get; set; }
    public Course Course { get; set; }

    [Column(TypeName = "decimal(5,2)")]
    public decimal Grade { get; set; }
}
