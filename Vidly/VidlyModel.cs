namespace Vidly
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Vidly.Models;

    public partial class VidlyModel : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public VidlyModel()
            : base("name=VidlyDbConfig")
        {

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
