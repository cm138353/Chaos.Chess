using System;
using System.Collections.Generic;
using System.Text;

namespace Chaos.Chess.Games
{
    public class ChessGameDto
    {
        public string GameSan{get; set;}
        public string GameFen{get; set;}
        public string GameAscii{get; set;}
        public DateTime DateStarted{get; set;}
        public DateTime DateFinished{get; set;}
        public GameStatusDto GameStatus{ get; set; }
    }
}
