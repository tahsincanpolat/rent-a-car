using RentACar.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.ORM.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {
            // Database e bağlanma (Entity Framework)  
            Database.Connection.ConnectionString = "Server=OGRETMEN;Database=RentACar;uid=sa;pwd=1453";
        }

        // DbSet => Database te Tablolara denk gelen kısımları oluşturacağız.

        public DbSet<Arabalar> Arabalars { get; set; }
        public DbSet<Yoneticiler> Yoneticilers { get; set; }
        public DbSet<Kiralama> Kiralamas { get; set; }

        // Migration (Göç - Transfer)
        // enable-migrations
        // add-migration 'a'
        // update-database

    }
}
