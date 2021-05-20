using System.Collections.Generic;
using System;
using System.Linq;
using interview6.Interfaces;
namespace interview6
{
    public class SnakevsLadder : ISnakevsLadder
    {
        private int diceSize;
        private int endPos;
        private Random random = new Random();
        private List<IColumnType> grid;
        private List<IPlayer> players;
        public SnakevsLadder(List<IColumnType> grid, List<IPlayer> players, int diceSize)
        {
            this.grid= grid;
            this.players = players;
            this.diceSize = diceSize;
            this.endPos = grid.Count()-1;
        }

        public IPlayer GamePlay(IPlayer player, int diceValue)
        {
            var pos = player.GetCurrentPosition();
            IPlayer newPlayer =null;
            var endPos =grid.Count()-1;
            if(pos + diceSize<=endPos)
            {
                var newPos = grid[pos+diceSize].GetNextPosition();
                newPlayer = player.UpdateCurrentPosition(newPos);
                if(newPos ==endPos)
                {
                    newPlayer.SetWinner();
                }
            }
            return (newPlayer==null)? player: newPlayer;
        }

        public IPlayer Play()
        {
            while(players.Where(x => x.IsWinner()).Count()==0)
            {
                for(int i=0;i<players.Count();i++)
                {
                    var number = rollDice();
                    players[i] = GamePlay(players[i], number);
                    if(players[i].IsWinner())
                        break;
                    
                }
            }
            var winner = players.Where(x => x.IsWinner()).FirstOrDefault();
            Console.WriteLine("Winner is ");
            Console.WriteLine(winner);
            return winner;
        }
        public int rollDice()
        {           
            var result = random.Next(diceSize); 
            Console.WriteLine("result is "+result);
            return result;
        }
    }
}