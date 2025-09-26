using Assignment_Day03.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment_Day03.Data.Config
{
    public class StudentCrsConfigration : IEntityTypeConfiguration<StuCrsRes>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<StuCrsRes> builder)
        {
            builder.HasKey(sc => new { sc.StudentId, sc.CourseId });
        }
    }
}
