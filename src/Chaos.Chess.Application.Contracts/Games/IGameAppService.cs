using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Chaos.Chess.Games
{
    public interface IGameAppService : IApplicationService
    {
        Task<ChessGameDto> GetChessGameAsync();
    }
}
