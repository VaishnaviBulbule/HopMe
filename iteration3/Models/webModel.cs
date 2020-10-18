namespace iteration3.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class webModel : DbContext
    {
        public webModel()
            : base("name=webModel")
        {
        }

        public virtual DbSet<agegroup> agegroup { get; set; }
        public virtual DbSet<English_Profeciency> English_Profeciency { get; set; }
        public virtual DbSet<filed_study> filed_study { get; set; }
        public virtual DbSet<gender> gender { get; set; }
        public virtual DbSet<Highest_education> Highest_education { get; set; }
        public virtual DbSet<prediction> prediction { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<agegroup>()
                .Property(e => e.ageGroup1)
                .IsUnicode(false);

            modelBuilder.Entity<English_Profeciency>()
                .Property(e => e.degree)
                .IsUnicode(false);

            modelBuilder.Entity<filed_study>()
                .Property(e => e.degree)
                .IsUnicode(false);

            modelBuilder.Entity<gender>()
                .Property(e => e.gender1)
                .IsUnicode(false);

            modelBuilder.Entity<Highest_education>()
                .Property(e => e.degree)
                .IsUnicode(false);

            modelBuilder.Entity<prediction>()
                .Property(e => e.pred_1)
                .IsUnicode(false);

            modelBuilder.Entity<prediction>()
                .Property(e => e.pred_2)
                .IsUnicode(false);

            modelBuilder.Entity<prediction>()
                .Property(e => e.pred_3)
                .IsUnicode(false);
        }
    }
}
