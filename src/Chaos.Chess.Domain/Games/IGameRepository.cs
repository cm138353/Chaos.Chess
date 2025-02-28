﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;

namespace Chaos.Chess.Games
{
    public interface IGameRepository : IBasicRepository<ChessGame, Guid>
    {
        Task<ChessGame> GetChessGame(
            Guid id,
            bool includeDetails = false,
            CancellationToken cancellationToken = default
        );


    }
}
