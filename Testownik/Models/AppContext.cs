using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testownik.Models
{
    class AppContext : DbContext
    {
        public AppContext() : base("DefaultConnection")
        {
            Database.Initialize(false);
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Quiz> Quizes { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }
}
