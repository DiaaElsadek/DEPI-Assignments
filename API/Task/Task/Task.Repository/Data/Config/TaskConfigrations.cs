using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Repository.Data.Config
{
    public class TaskConfigrations : IEntityTypeConfiguration<Core.Entity.Task>
    {
        public void Configure(EntityTypeBuilder<Core.Entity.Task> builder)
        {
            builder.ToTable("Tasks");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Title).IsRequired().HasMaxLength(100);
            builder.Property(t => t.Description).HasMaxLength(500);
            builder.Property(t => t.IsCompleted).IsRequired();
        }
    }
}
