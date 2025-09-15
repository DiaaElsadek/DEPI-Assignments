using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;

// Author Entity
public class Author
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }

    // One-to-Many: Author -> Books
    public ICollection<Book> Books { get; set; } = new List<Book>();
}

// Book Entity
public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string ISBN { get; set; }

    public int AuthorId { get; set; }
    public Author Author { get; set; }

    // Many-to-Many with Borrower through Loan
    public ICollection<Loan> Loans { get; set; } = new List<Loan>();
}

// Borrower Entity
public class Borrower
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime MembershipDate { get; set; }

    // Many-to-Many with Book through Loan
    public ICollection<Loan> Loans { get; set; } = new List<Loan>();
}

// Loan Entity (Join Table for Many-to-Many)
public class Loan
{
    public int BookId { get; set; }
    public Book Book { get; set; }

    public int BorrowerId { get; set; }
    public Borrower Borrower { get; set; }

    public DateTime LoanDate { get; set; }
    public DateTime? ReturnDate { get; set; }
}

public class AuthorConfig : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Name).IsRequired().HasMaxLength(100);
    }
}

public class BookConfig : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(b => b.Id);
        builder.Property(b => b.Title).IsRequired().HasMaxLength(200);
        builder.Property(b => b.ISBN).HasMaxLength(20);

        // One-to-Many : Book belongs to one Author
        builder.HasOne(b => b.Author)
               .WithMany(a => a.Books)
               .HasForeignKey(b => b.AuthorId);
    }
}

public class BorrowerConfig : IEntityTypeConfiguration<Borrower>
{
    public void Configure(EntityTypeBuilder<Borrower> builder)
    {
        builder.HasKey(b => b.Id);
        builder.Property(b => b.Name).IsRequired().HasMaxLength(100);
    }
}

public class LoanConfig : IEntityTypeConfiguration<Loan>
{
    public void Configure(EntityTypeBuilder<Loan> builder)
    {
        builder.HasKey(l => new { l.BookId, l.BorrowerId, l.LoanDate });

        // Many-to-Many : Loan connects Book & Borrower
        builder.HasOne(l => l.Book)
               .WithMany(b => b.Loans)
               .HasForeignKey(l => l.BookId);

        builder.HasOne(l => l.Borrower)
               .WithMany(b => b.Loans)
               .HasForeignKey(l => l.BorrowerId);
    }
}

public class LibraryContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Borrower> Borrowers { get; set; }
    public DbSet<Loan> Loans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.;Database=LibraryDB;Trusted_Connection=True;Encrypt=False");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AuthorConfig());
        modelBuilder.ApplyConfiguration(new BookConfig());
        modelBuilder.ApplyConfiguration(new BorrowerConfig());
        modelBuilder.ApplyConfiguration(new LoanConfig());
    }
}

class Program
{
    static void Main(string[] args)
    {
        using var context = new LibraryContext();

        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();

        Console.WriteLine("Library Database Created with Relationships");
    }
}
