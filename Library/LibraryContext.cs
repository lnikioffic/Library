using System;
using System.Collections.Generic;
using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library;

public partial class LibraryContext : DbContext
{
    public LibraryContext()
    {
    }

    public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<AuthorBook> AuthorBooks { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<BookGenre> BookGenres { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Journal> Journals { get; set; }

    public virtual DbSet<Publishing> Publishings { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=library;Username=postgres;Password=Nikita2002");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.Id).HasName(" Author_pkey");

            entity.ToTable(" Author");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("last_name");
            entity.Property(e => e.Patronymic)
                .HasMaxLength(255)
                .HasColumnName("patronymic");
        });

        modelBuilder.Entity<AuthorBook>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Author_Book_pkey");

            entity.ToTable("Author_Book");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AuthorId).HasColumnName("author_id");
            entity.Property(e => e.BookId).HasColumnName("book_id");

            entity.HasOne(d => d.Author).WithMany(p => p.AuthorBooks)
                .HasForeignKey(d => d.AuthorId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_author_book_author");

            entity.HasOne(d => d.Book).WithMany(p => p.AuthorBooks)
                .HasForeignKey(d => d.BookId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_author_book_book");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Book_pkey");

            entity.ToTable("Book");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PublicationDate)
                .HasMaxLength(255)
                .HasColumnName("publication_date");
            entity.Property(e => e.PublishingId).HasColumnName("publishing_id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");

            entity.HasOne(d => d.Publishing).WithMany(p => p.Books)
                .HasForeignKey(d => d.PublishingId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_book_publishing");
        });

        modelBuilder.Entity<BookGenre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Book_Genre_pkey");

            entity.ToTable("Book_Genre");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BookId).HasColumnName("book_id");
            entity.Property(e => e.GenreId).HasColumnName("genre_id");

            entity.HasOne(d => d.Book).WithMany(p => p.BookGenres)
                .HasForeignKey(d => d.BookId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_book_genre_book");

            entity.HasOne(d => d.Genre).WithMany(p => p.BookGenres)
                .HasForeignKey(d => d.GenreId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_book_genre_genre");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Genre_pkey");

            entity.ToTable("Genre");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Genre1)
                .HasMaxLength(255)
                .HasColumnName("genre");
        });

        modelBuilder.Entity<Journal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Journal_pkey");

            entity.ToTable("Journal");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActualReturnDate).HasColumnName("actual_return_date");
            entity.Property(e => e.BookId).HasColumnName("book_id");
            entity.Property(e => e.DateOfIssued).HasColumnName("date_of_issued");
            entity.Property(e => e.EstimatedReturnDate).HasColumnName("estimated_return_date");
            entity.Property(e => e.UserIssuedId).HasColumnName("user_issued_id");
            entity.Property(e => e.UserTookId).HasColumnName("user_took_id");

            entity.HasOne(d => d.Book).WithMany(p => p.Journals)
                .HasForeignKey(d => d.BookId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_journal_book");

            entity.HasOne(d => d.UserIssued).WithMany(p => p.JournalUserIssueds)
                .HasForeignKey(d => d.UserIssuedId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_journal_user_issued");

            entity.HasOne(d => d.UserTook).WithMany(p => p.JournalUserTooks)
                .HasForeignKey(d => d.UserTookId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_journal_user_took");
        });

        modelBuilder.Entity<Publishing>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Publishing_pkey");

            entity.ToTable("Publishing");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("User_pkey");

            entity.ToTable("User");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("last_name");
            entity.Property(e => e.Patronymic)
                .HasMaxLength(255)
                .HasColumnName("patronymic");
            entity.Property(e => e.Role).HasColumnName("role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
