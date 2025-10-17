using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Test.ConfigurationClasses
{
    public class TaskConfiguration : IEntityTypeConfiguration<TaskItem>
    {
        public void Configure(EntityTypeBuilder<TaskItem> builder)
        {
            builder.Property(t => t.Title)
                .HasMaxLength(100);
            builder.Property(t => t.Description)
                .HasMaxLength(500);
            builder.Property(t => t.CreatedAt)
                .HasDefaultValueSql("getDate()");
        }
    }
}
