using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Chaos.Chess.Games
{
    public class GameStatus : Entity<Guid>
    {
        public GameState State {get;set;}
        public Turn Turn  {get;set;}
        public Winner Winner {get;set;}
        public string Reason { get; set; }

    }
}
