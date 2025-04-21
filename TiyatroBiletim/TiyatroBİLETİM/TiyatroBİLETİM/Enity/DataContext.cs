using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TiyatroBİLETİM.Enity
{
    public class DataContext : DbContext
    {
        public DataContext() : base("dataConnection")
        {
            Database.SetInitializer(new DataInitializer());
        }
        public DbSet<Oyunlarim> Oyunlars { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }

    }
}