using ManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Context
{
    public class LoginContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog= MyLOGIN_MANAGER ;Integrated Security=True;Encrypt=False");
        }
        public DbSet<frontendLogin> frontendLogins { get; set; }
        public DbSet<kitchenLogin> kitchenLogins { get; set; }

    }
}
