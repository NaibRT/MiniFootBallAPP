using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootBall_App.Model
{
    public class Team : Entity
    {
        public Team()
        {
            Players = new HashSet<User>();
        }
        public string Name { get; set; }
        public int Scorr { get; set; }

        public ICollection<User> Players{get;set;}

    }
}
