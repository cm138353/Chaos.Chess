using System;
using System.Collections.Generic;
using System.Text;

namespace Chaos.Chess.Games
{
    public enum GameState
    {
        Active = 0,
        Checkmate = 1,
        Resigned = 2,
        DrawOther = 3,
        DrawStalemate = 4,
        DrawRepetition = 5,
        DrawFiftyMoves = 6,
        DrawNoMaterial = 7
    }
}
