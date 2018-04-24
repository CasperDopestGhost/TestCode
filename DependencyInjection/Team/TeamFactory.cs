using System;
using System.Collections.Generic;
using System.Text;

namespace Team
{
    public class TeamFactory
    {
        ITeam team = null;


        public TeamFactory (ITeam concreteTeam)
        {
            team = concreteTeam;
        }

        public void GetPlayers()
        {
            team.GetTeam();
        }
    }
}
