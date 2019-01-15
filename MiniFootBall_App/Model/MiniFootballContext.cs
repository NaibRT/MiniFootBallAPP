using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace MiniFootBall_App.Model
{
   public class MiniFootballContext:DbContext
    {
        public MiniFootballContext() : base("footballDB") { }
        public DbSet<Match> Matches { get; set; }
        public DbSet<User> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
