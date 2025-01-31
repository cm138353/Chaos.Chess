using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaos.Chess.Games
{
    public class GameAppService : ChessAppService
    {
        private readonly IGameRepository _repository;

        public GameAppService(IGameRepository repository)
        {
            this._repository = repository;
        }

        public async Task<ChessGameDto> GetChessGameAsync(Guid id)
        {

            var game = await _repository.GetAsync(id);
            var gameDto = ObjectMapper.Map<ChessGame, ChessGameDto>(game);

            return gameDto;
        }


    }
}
