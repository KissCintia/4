using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Data
{
    public class AdatContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\MsSqlLocalDb;Database=Nyilvantartas;Trusted_Connection=True;");
            string myConnectionString = "Server=127.0.0.1;User ID=root;  Password=;Database=4";
            optionsBuilder.UseMySql(myConnectionString, ServerVersion.AutoDetect(myConnectionString));
        }
        public DbSet<Nyilvantartas> Nyilvantartasok { get; set; }
    }
}
