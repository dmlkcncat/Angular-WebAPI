using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class LinkOlusturContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=LinkOlustur; Trusted_Connection=true");

        }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Link> Link { get; set; }
    }
}
