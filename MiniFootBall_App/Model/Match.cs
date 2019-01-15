using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootBall_App.Model
{
   public class Match:Entity
    {
        public DateTime GameTime { get; set; }
        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; }
        public int AwayTeam_Score { get; set; }

        public int GuestTeam_Score { get; set; }
        public int GuestTeamId { get; set; }
        public Team GuestTeam { get; set; }


    }
}
