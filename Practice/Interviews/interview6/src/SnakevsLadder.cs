using System.Collections.Generic;
using System;
using System.Linq;
using interview6.Interfaces;
namespace interview6
{
    public class SnakevsLadder : ISnakevsLadder
    {
        private int diceSize;
        private Random random = new Random();
        private List<IColumnType> grid;
        private List<IPlayer> players;
        public SnakevsLadder(List<IColumnType> grid, List<IPlayer> players, int diceSize)
        {
            this.grid= grid;
            this.players = players;
            this.diceSize = diceSize;
        }

        public void GamePlay(IPlayer player, int diceValue)
        {
            var pos = player.GetCurrentPosition();
            if(pos + diceSize<=99)
            {
                var newPos = grid[pos+diceSize].GetNextPosition();
                player.UpdateCurrentPosition(newPos);
                if(newPos ==99)
                {
                    player.SetWinner();
                }
            }
        }

        public void Play()
        {
            while(players.Where(x => x.IsWinner()).Count()==0)
            {
                for(int i=0;i<players.Count();i++)
                {
                    var number = rollDice();
                    GamePlay(players[i], number);
                    if(players[i].IsWinner())
                        break;
                    
                }
            }
            var winner = players.Where(x => x.IsWinner()).FirstOrDefault();
            Console.WriteLine("Winner is ");
            Console.WriteLine(winner);
        }
        public int rollDice()
        {           
            return random.Next(diceSize);
        }
    }
}