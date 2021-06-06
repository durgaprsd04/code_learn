using System;
using System.Collections.Generic;
using System.Linq;

namespace mineSweeper
{
    public class Server : IServer
    {
        IUser user;
        IGrid grid;
       
       
        private bool isWon;
        private bool isFinished;
        public Server(IUser user, IGrid grid)
        {
            this.user = user;
            this.grid = grid;
        }

        public bool IsWon { get => isWon; set => isWon = value; }

        public void GamePlay()
        {
           var command= user.GetInput(grid);
           grid = command.Execute();
           if(grid.isExploded(command.GetCell()))
           {
               isWon=false;
               isFinished=true;
           }
        }
        public void Start()
        {
            while(!isWon && !isFinished)
            {
                GamePlay();
            }
        }
    }
}
/*
 if(p< m && q< n)
           { 
              
               else
               {
                   if(cells.Where(x => x.IsOpen()).Count() == cells.Where(x => x.IsMine()).Count())
                    { 
                        isWon=true;
                        isFinished=true;
                    }
               }
           }
*/