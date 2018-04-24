using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Angular.Controllers
{
    [Produces("application/json")]
    [Route("api/Player")]
    public class PlayerController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<Player> GetPlayers(int teamid)
        {
            return new List<Player>
            {
                new Player{PlayerId= 1, PlayerName="Mike Meyer", TeamId= 1},
                new Player{PlayerId= 2, PlayerName="Tom Meyer", TeamId= 1},
                new Player{PlayerId= 3, PlayerName="Kevin Meyer", TeamId = 1},
                new Player{PlayerId= 4, PlayerName="Sarah Bayer", TeamId= 1},
                new Player{PlayerId= 5, PlayerName="Chuck Bayer", TeamId= 2},
                new Player{PlayerId= 6, PlayerName="Karen Bayer", TeamId= 2},
                new Player{PlayerId= 7, PlayerName="Charlotte Bayer", TeamId= 2},
                new Player{PlayerId= 8, PlayerName="Mason Bayer", TeamId= 3},
                new Player{PlayerId= 9, PlayerName="Rondon Meyer", TeamId = 3},
                new Player{PlayerId= 10, PlayerName="Charlie Brown", TeamId= 3},
                new Player{PlayerId= 11, PlayerName="Pele", TeamId= 3},
                new Player{PlayerId= 12, PlayerName="Maradona", TeamId= 3}

            };
        }
    }


    public class Player
    {
        public int PlayerId { get; set; }

        public string PlayerName { get; set; }

        public int TeamId { get; set; }

    }

}