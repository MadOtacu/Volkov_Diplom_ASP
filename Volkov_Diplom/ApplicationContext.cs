using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volkov_Diplom.Models;

namespace Volkov_Diplom
{
    class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<HelpBox> HelpBoxes { get; set; }

        public DbSet<Question> Questions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = DataBase.db");
        }
    }
}
