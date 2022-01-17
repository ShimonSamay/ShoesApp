using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SneakersShops.Models
{
    public partial class ShoesDBContext : DbContext
    {
        public ShoesDBContext()
            : base("name=ShoesDBContext")
        {
        }
        public virtual DbSet<ExistShoes> ExitShoes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
