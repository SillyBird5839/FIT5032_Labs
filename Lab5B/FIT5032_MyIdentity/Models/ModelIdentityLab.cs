using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FIT5032_MyIdentity.Models
{
    public partial class ModelIdentityLab : DbContext
    {
        public ModelIdentityLab()
            : base("name=ModelIdentityLab")
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(e => e.Units)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);
        }
    }
}
