namespace _1061109_FirstNetMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ComGropModel : DbContext
    {
        public ComGropModel()
            : base("name=ComGropModel")
        {
        }

        public virtual DbSet<ComGroup> ComGroups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
