namespace CMS
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Abortion> Abortions { get; set; }
        public virtual DbSet<Animal> Animals { get; set; }
        public virtual DbSet<Breeding> Breedings { get; set; }
        public virtual DbSet<Buyer> Buyers { get; set; }
        public virtual DbSet<Calving> Calvings { get; set; }
        public virtual DbSet<DryPeriod> DryPeriods { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<FeedStock> FeedStocks { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }
        public virtual DbSet<Milking> Milkings { get; set; }
        public virtual DbSet<AniEmployee> AniEmployees { get; set; }
        public virtual DbSet<Feeding> Feedings { get; set; }
        public virtual DbSet<Medication> Medications { get; set; }
        public virtual DbSet<MilkBuyer> MilkBuyers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Animal>()
                .Property(e => e.OriginCountry)
                .IsUnicode(false);

            modelBuilder.Entity<Animal>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Animal>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Animal>()
                .Property(e => e.Breed)
                .IsUnicode(false);

            modelBuilder.Entity<Animal>()
                .Property(e => e.Lactation)
                .IsUnicode(false);

            modelBuilder.Entity<Animal>()
                .HasOptional(e => e.AniEmployee)
                .WithRequired(e => e.Animal);

            modelBuilder.Entity<Animal>()
                .HasMany(e => e.Breedings)
                .WithOptional(e => e.Animal)
                .HasForeignKey(e => e.Animal_ID);

            modelBuilder.Entity<Animal>()
                .HasMany(e => e.Breedings1)
                .WithOptional(e => e.Animal1)
                .HasForeignKey(e => e.Animal_ID_M);

            modelBuilder.Entity<Animal>()
                .HasMany(e => e.Calvings)
                .WithRequired(e => e.Animal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Animal>()
                .HasMany(e => e.DryPeriods)
                .WithRequired(e => e.Animal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Animal>()
                .HasMany(e => e.Medications)
                .WithRequired(e => e.Animal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Breeding>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Breeding>()
                .Property(e => e.Dose)
                .IsUnicode(false);

            modelBuilder.Entity<Buyer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Buyer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Buyer>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Buyer>()
                .HasMany(e => e.MilkBuyers)
                .WithRequired(e => e.Buyer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Calving>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Calving>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.F_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.FeedStocks)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FeedStock>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<FeedStock>()
                .Property(e => e.Unit)
                .IsFixedLength();

            modelBuilder.Entity<FeedStock>()
                .HasOptional(e => e.Feeding)
                .WithRequired(e => e.FeedStock);

            modelBuilder.Entity<Medicine>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Medicine>()
                .Property(e => e.Unit)
                .IsFixedLength();

            modelBuilder.Entity<Medicine>()
                .HasMany(e => e.Medications)
                .WithRequired(e => e.Medicine)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Milking>()
                .HasMany(e => e.MilkBuyers)
                .WithRequired(e => e.Milking)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AniEmployee>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<Feeding>()
                .Property(e => e.Method)
                .IsUnicode(false);

            modelBuilder.Entity<Medication>()
                .Property(e => e.Disease)
                .IsUnicode(false);

            modelBuilder.Entity<Medication>()
                .Property(e => e.Method)
                .IsUnicode(false);
        }
    }
}
