﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace LeagueAPI.Application.Controllers
{
    [Produces("application/json")]
    [Route("api/games")]
    public class GamesController : Controller
    {
     

        [HttpPost("/addgame")]
        public bool AddGameDetails([FromBody]List<string> players, [FromBody]string winner)
        {
            
            return false;
        }
    }
}