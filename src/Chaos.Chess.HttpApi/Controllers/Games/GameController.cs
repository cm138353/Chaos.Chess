using Chaos.Chess.Games;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Volo.Abp;

namespace Chaos.Chess.Controllers.Games
{
    [RemoteService(Name = "ChessAdmin")]
    [Area("Chess")]
    [ControllerName("Game")]
    [Route("api/Chess/Game")]
    public class GameController : ChessController
    {
        private readonly IGameAppService _appService;

        public GameController(IGameAppService appService)
        {
            _appService = appService;
        }

        [HttpGet]
        [Route("get-current-game")]
        public async Task<ChessGameDto> Get()
        {

            return await _appService.GetChessGameAsync();
        }
    }
}
