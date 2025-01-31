using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Chaos.Chess.Games
{
    public class ChessGame: AggregateRoot<Guid>
    {
        public string GameSan { get; set; }
        public string GameFen { get; set; }
        public string GameAscii { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateFinished { get; set; }
        public GameStatus GameStatus { get; set; }

        protected ChessGame() { }
        public ChessGame(Guid id)
        {
            Id = id;

        }
    }
}
