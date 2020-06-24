using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace Library
{
    public partial class LibContext : DbContext
    {
        public LibContext()
        {
        }

        public LibContext(DbContextOptions<LibContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<BooksAuhors> BooksAuhors { get; set; }
        public virtual DbSet<BooksCategorys> BooksCategorys { get; set; }
        public virtual DbSet<BooksGenrys> BooksGenrys { get; set; }
        public virtual DbSet<Categorys> Categorys { get; set; }
        public virtual DbSet<Employments> Employments { get; set; }
        public virtual DbSet<EmploymentsUsers> EmploymentsUsers { get; set; }
        public virtual DbSet<Genrys> Genrys { get; set; }
        public virtual DbSet<Publishings> Publishings { get; set; }
        public virtual DbSet<RecordsBooks> RecordsBooks { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<_14> _14 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Server = localhost;Port=5432;Database=Lib;Username=postgres;Password=1;Integrated Security=true;Pooling=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authors>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("date_of_birth")
                    .HasColumnType("date");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<Books>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Img).HasColumnName("img");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.PublishingsId).HasColumnName("Publishings_id");

                entity.Property(e => e.YPublishing)
                    .HasColumnName("y_publishing");

                entity.HasOne(d => d.Publishings)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.PublishingsId)
                    .HasConstraintName("Books_Publishings_id_fkey");
            });

            modelBuilder.Entity<BooksAuhors>(entity =>
            {
                entity.ToTable("Books_Auhors");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuthorsId).HasColumnName("authors_id");

                entity.Property(e => e.BooksId).HasColumnName("books_id");

                entity.HasOne(d => d.Authors)
                    .WithMany(p => p.BooksAuhors)
                    .HasForeignKey(d => d.AuthorsId)
                    .HasConstraintName("Books_Auhors_authors_id_fkey");

                entity.HasOne(d => d.Books)
                    .WithMany(p => p.BooksAuhors)
                    .HasForeignKey(d => d.BooksId)
                    .HasConstraintName("Books_Auhors_books_id_fkey");
            });

            modelBuilder.Entity<BooksCategorys>(entity =>
            {
                entity.ToTable("Books_Categorys");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BooksId).HasColumnName("books_id");

                entity.Property(e => e.CategorysId).HasColumnName("categorys_id");

                entity.HasOne(d => d.Books)
                    .WithMany(p => p.BooksCategorys)
                    .HasForeignKey(d => d.BooksId)
                    .HasConstraintName("Books_Categorys_books_id_fkey");

                entity.HasOne(d => d.Categorys)
                    .WithMany(p => p.BooksCategorys)
                    .HasForeignKey(d => d.CategorysId)
                    .HasConstraintName("Books_Categorys_categorys_id_fkey");
            });

            modelBuilder.Entity<BooksGenrys>(entity =>
            {
                entity.ToTable("Books_Genrys");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BooksId).HasColumnName("books_id");

                entity.Property(e => e.GenrysId).HasColumnName("genrys_id");

                entity.HasOne(d => d.Books)
                    .WithMany(p => p.BooksGenrys)
                    .HasForeignKey(d => d.BooksId)
                    .HasConstraintName("Books_Genrys_books_id_fkey");

                entity.HasOne(d => d.Genrys)
                    .WithMany(p => p.BooksGenrys)
                    .HasForeignKey(d => d.GenrysId)
                    .HasConstraintName("Books_Genrys_genrys_id_fkey");
            });

            modelBuilder.Entity<Categorys>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<Employments>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adress).HasColumnName("adress");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Telephone).HasColumnName("telephone");
            });

            modelBuilder.Entity<EmploymentsUsers>(entity =>
            {
                entity.ToTable("Employments_Users");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmpoymentsId).HasColumnName("Empoyments_id");

                entity.Property(e => e.UsersId).HasColumnName("Users_id");

                entity.HasOne(d => d.Empoyments)
                    .WithMany(p => p.EmploymentsUsers)
                    .HasForeignKey(d => d.EmpoymentsId)
                    .HasConstraintName("Employments_Users_Empoyments_id_fkey");

                entity.HasOne(d => d.Users)
                    .WithMany(p => p.EmploymentsUsers)
                    .HasForeignKey(d => d.UsersId)
                    .HasConstraintName("Employments_Users_Users_id_fkey");
            });

            modelBuilder.Entity<Genrys>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<Publishings>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adress).HasColumnName("adress");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Telephone).HasColumnName("telephone");
            });

            modelBuilder.Entity<RecordsBooks>(entity =>
            {
                entity.ToTable("Records_Books");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BooksId).HasColumnName("Books_id");

                entity.Property(e => e.CheckGive)
                    .HasColumnName("check_give")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.DateDrop)
                    .HasColumnName("date_drop")
                    .HasColumnType("date");

                entity.Property(e => e.TimeToDrop)
                    .HasColumnName("time_to_drop")
                    .HasColumnType("daterange");

                entity.Property(e => e.UsersId).HasColumnName("Users_id");

                entity.HasOne(d => d.Books)
                    .WithMany(p => p.RecordsBooks)
                    .HasForeignKey(d => d.BooksId)
                    .HasConstraintName("Records_Books_Books_id_fkey");

                entity.HasOne(d => d.Users)
                    .WithMany(p => p.RecordsBooks)
                    .HasForeignKey(d => d.UsersId)
                    .HasConstraintName("Records_Books_Users_id_fkey");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("char");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Login).HasColumnName("login");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Password).HasColumnName("password");
            });

            modelBuilder.Entity<_14>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("14");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
