using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Lab
{
    class DbWorker : DbContext
    {
        public DbWorker() : base("DbCon") { }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DbContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
