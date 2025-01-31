using System;
using System.Collections.Generic;
using System.Text;

namespace Chaos.Chess.Games
{
    public class GameStatusDto
    {
        public int State { get; set; }
        public int Turn { get; set; }
        public int Winner { get; set; }
        public string Reason { get; set; }
        public GameStatusDto() { }
    }
}
