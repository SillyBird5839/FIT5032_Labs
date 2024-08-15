using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FIT5032_Week05E_1.Models
{
    public partial class FIT5032_WEEK05_MODELS : DbContext
    {
        public FIT5032_WEEK05_MODELS()
            : base("name=FIT5032_WEEK05_MODELS")
        {
        }

        public virtual DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>()
                .Property(e => e.Contents)
                .IsUnicode(false);
        }
    }
}
