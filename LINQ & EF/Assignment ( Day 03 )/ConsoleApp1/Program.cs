using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.ComponentModel.DataAnnotations;

public class Project
{
    public int Id { get; set; }
    public string Name { get; set; } = "OurProject";
    public decimal Cost { get; set; }
}

public class ProjectConfig : IEntityTypeConfiguration<Project>
{
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        // Q1 - Id PK with identity (10,10)
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id)
               .UseIdentityColumn(seed: 10, increment: 10);

        // Q2 - Name prop -> varchar(50), default = "OurProject", required
        builder.Property(p => p.Name)
               .HasColumnType("varchar(50)")
               .HasDefaultValue("OurProject")
               .IsRequired();

        // Q3 - Cost -> Money datatype + range
        builder.Property(p => p.Cost)
               .HasColumnType("money");

        // Q4 - Range constraint using Check
        builder.HasCheckConstraint("CK_Project_Cost", "Cost BETWEEN 500000 AND 3500000");
    }
}

public class MyDbContext : DbContext
{
    public DbSet<Project> Projects { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProjectConfig());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.;Database=MyCompany;Trusted_Connection=True;Encrypt=False");
    }

    class Program
    {
        static void Main(string[] args)
        {
            using var context = new MyDbContext();

            context.Database.EnsureCreated();

            Console.WriteLine("Database Created with Project Configurations ✅");
        }
    }


}
