﻿using BitPoker.Models.GameContext;
using BitPoker.Models.Players;

namespace BitPoker.Logic.Players
{
    public abstract class PlayerDecorator : IPlayerLogic
    {
        protected PlayerDecorator(IPlayerLogic player)
        {
            this.Player = player;
        }

        public virtual string Name => this.Player.Name;

        protected BitPoker.Models.Players.IPlayerLogic Player { get; }

        public virtual void StartGame(IStartGameContext context)
        {
            this.Player.StartGame(context);
        }

        public virtual void StartHand(IStartHandContext context)
        {
            this.Player.StartHand(context);
        }

        public virtual void StartRound(IStartRoundContext context)
        {
            this.Player.StartRound(context);
        }

        public virtual PlayerAction GetTurn(IGetTurnContext context)
        {
            return this.Player.GetTurn(context);
        }

        public virtual void EndRound(IEndRoundContext context)
        {
            this.Player.EndRound(context);
        }

        public virtual void EndHand(IEndHandContext context)
        {
            this.Player.EndHand(context);
        }

        public virtual void EndGame(IEndGameContext context)
        {
            this.Player.EndGame(context);
        }
    }
}
