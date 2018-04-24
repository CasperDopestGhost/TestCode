using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeyerPremierLeagueTeams;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Angular.Controllers
{
    [Route("api/[controller]")]
    public class TeamController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<Team> GetTeams()
        {
            return new List<Team>
            {
                new Team{Id= 1, TeamName="LA Galaxy"},
                new Team{Id= 2, TeamName="Toronto FC"},
                new Team{Id= 3, TeamName="Chicago Fire"},
                new Team{Id= 4, TeamName="New York Red Bulls"}
            };
        }
    }



    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
    }
}