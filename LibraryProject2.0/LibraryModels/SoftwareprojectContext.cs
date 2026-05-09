using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject2._0.LibraryModels;

public partial class SoftwareprojectContext : DbContext
{
    public SoftwareprojectContext()
    {
    }

    public SoftwareprojectContext(DbContextOptions<SoftwareprojectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<BookItem> BookItems { get; set; }

    public virtual DbSet<BookItemStatus> BookItemStatuses { get; set; }

    public virtual DbSet<Fine> Fines { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<ReservationStatus> ReservationStatuses { get; set; }

    public virtual DbSet<TakeOutRecord> TakeOutRecords { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=aekroe21.database.windows.net;Initial Catalog=softwareproject;Persist Security Info=True;User ID=aekroe;Password=AlmAs2rEtes;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.ToTable("Author");

            entity.Property(e => e.AuthorId).HasColumnName("AuthorID");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Origin).HasMaxLength(50);
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.ToTable("Book");

            entity.Property(e => e.BookId).HasColumnName("BookID");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Publisher).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(100);

            entity.HasMany(d => d.Authors).WithMany(p => p.Books)
                .UsingEntity<Dictionary<string, object>>(
                    "BookAuthor",
                    r => r.HasOne<Author>().WithMany()
                        .HasForeignKey("AuthorId")
                        .HasConstraintName("FK_BookAuthor_Author"),
                    l => l.HasOne<Book>().WithMany()
                        .HasForeignKey("BookId")
                        .HasConstraintName("FK_BookAuthor_Book"),
                    j =>
                    {
                        j.HasKey("BookId", "AuthorId");
                        j.ToTable("BookAuthor");
                        j.IndexerProperty<int>("BookId").HasColumnName("BookID");
                        j.IndexerProperty<int>("AuthorId").HasColumnName("AuthorID");
                    });

            entity.HasMany(d => d.Genres).WithMany(p => p.Books)
                .UsingEntity<Dictionary<string, object>>(
                    "BookGenre",
                    r => r.HasOne<Genre>().WithMany()
                        .HasForeignKey("GenreId")
                        .HasConstraintName("FK_BookGenre_Genre"),
                    l => l.HasOne<Book>().WithMany()
                        .HasForeignKey("BookId")
                        .HasConstraintName("FK_BookGenre_Book"),
                    j =>
                    {
                        j.HasKey("BookId", "GenreId");
                        j.ToTable("BookGenre");
                        j.IndexerProperty<int>("BookId").HasColumnName("BookID");
                        j.IndexerProperty<int>("GenreId").HasColumnName("GenreID");
                    });
        });

        modelBuilder.Entity<BookItem>(entity =>
        {
            entity.HasKey(e => e.Barcode);

            entity.ToTable("BookItem");

            entity.Property(e => e.BookId).HasColumnName("BookID");
            entity.Property(e => e.StatusCode)
                .HasMaxLength(20)
                .HasDefaultValue("Available", "DF_BookItem_Status");

            entity.HasOne(d => d.Book).WithMany(p => p.BookItems)
                .HasForeignKey(d => d.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BookItem_Book");

            entity.HasOne(d => d.StatusCodeNavigation).WithMany(p => p.BookItems)
                .HasForeignKey(d => d.StatusCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BookItem_StatusCode");
        });

        modelBuilder.Entity<BookItemStatus>(entity =>
        {
            entity.HasKey(e => e.StatusCode);

            entity.ToTable("BookItemStatus");

            entity.Property(e => e.StatusCode).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(100);
        });

        modelBuilder.Entity<Fine>(entity =>
        {
            entity.ToTable("Fine");

            entity.Property(e => e.FineId).HasColumnName("FineID");
            entity.Property(e => e.Amount).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.IssuedDate).HasDefaultValueSql("(CONVERT([date],getdate()))", "DF_Fine_IssuedDate");
            entity.Property(e => e.TakeOutId).HasColumnName("TakeOutID");

            entity.HasOne(d => d.TakeOut).WithMany(p => p.Fines)
                .HasForeignKey(d => d.TakeOutId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Fine_TakeOut");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.ToTable("Genre");

            entity.HasIndex(e => e.GenreName, "UQ_Genre_Name").IsUnique();

            entity.Property(e => e.GenreId).HasColumnName("GenreID");
            entity.Property(e => e.GenreName).HasMaxLength(50);
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.ToTable("Member");

            entity.HasIndex(e => e.Email, "UQ_Member_Email").IsUnique();

            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.JoinDate).HasDefaultValueSql("(CONVERT([date],getdate()))", "DF_Member_JoinDate");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(20);
        });

        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.ToTable("Reservation");

            entity.Property(e => e.ReservationId).HasColumnName("ReservationID");
            entity.Property(e => e.BookId).HasColumnName("BookID");
            entity.Property(e => e.ExpiresAt).HasColumnType("datetime");
            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.ReservedAt)
                .HasDefaultValueSql("(getdate())", "DF_Reservation_ReservedAt")
                .HasColumnType("datetime");
            entity.Property(e => e.StatusCode)
                .HasMaxLength(20)
                .HasDefaultValue("Pending", "DF_Reservation_Status");

            entity.HasOne(d => d.Book).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.BookId)
                .HasConstraintName("FK_Reservation_Book");

            entity.HasOne(d => d.Member).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Reservation_Member");

            entity.HasOne(d => d.StatusCodeNavigation).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.StatusCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Reservation_StatusCode");
        });

        modelBuilder.Entity<ReservationStatus>(entity =>
        {
            entity.HasKey(e => e.StatusCode);

            entity.ToTable("ReservationStatus");

            entity.Property(e => e.StatusCode).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(100);
        });

        modelBuilder.Entity<TakeOutRecord>(entity =>
        {
            entity.HasKey(e => e.TakeOutId);

            entity.ToTable("TakeOutRecord");

            entity.HasIndex(e => new { e.ReturnDate, e.DueDate }, "IX_TakeOut_Active");

            entity.Property(e => e.TakeOutId).HasColumnName("TakeOutID");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate)
                .HasDefaultValueSql("(getdate())", "DF_TakeOut_StartDate")
                .HasColumnType("datetime");

            entity.HasOne(d => d.BarcodeNavigation).WithMany(p => p.TakeOutRecords)
                .HasForeignKey(d => d.Barcode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TakeOut_BookItem");

            entity.HasOne(d => d.Member).WithMany(p => p.TakeOutRecords)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TakeOut_Member");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
