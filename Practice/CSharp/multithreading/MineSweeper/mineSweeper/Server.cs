using System;
using System.Collections.Generic;
using System.Linq;

namespace mineSweeper
{
    public class Server : IServer
    {
        IUser user;
        private List<ICell> cells ;
        private int m;
        private int n;

        private Dictionary<int, List<ICell>> associatedLists;
        private bool isWon;
        private bool isFinished;
        public Server(IUser user, List<ICell> cells,Dictionary<int, List<ICell>> associatedLists)
        {
            this.user = user;
            this.cells = cells;
            this.associatedLists = associatedLists;
            m = cells.Select(x => x.GetRow()).Max();
            n = cells.Select(x => x.GetCol()).Max();
        }

        public bool IsWon { get => isWon; set => isWon = value; }

        public void GamePlay()
        {
           var cellId = user.GetCellId();
           var command= user.GetInput(cells[cellId]);
           cells[cellId] = command.Execute();
           if(cells[cellId].isExploded())
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