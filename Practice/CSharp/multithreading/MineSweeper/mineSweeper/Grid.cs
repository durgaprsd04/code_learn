using System;
using System.Linq;
using System.Collections.Generic;
namespace mineSweeper
{
    public class Grid :IGrid
    {
        private List<ICell> cells ;
        private Dictionary<int, List<ICell>> associatedLists;
        public bool isExploded(ICell cell)
        {
            var newCell = cells.Where(x => x.GetId()==cell.GetId()).FirstOrDefault();
            return newCell.isExploded();
        }

        public bool IsMarked(ICell cell)
        {
             var newCell = cells.Where(x => x.GetId()==cell.GetId()).FirstOrDefault();
            return newCell.IsMarked();
        }

        public bool IsMine(ICell cell)
        {
            var newCell = cells.Where(x => x.GetId()==cell.GetId()).FirstOrDefault();
            return newCell.IsMine();
        }

        public bool IsOpen(ICell cell)
        {
            var newCell = cells.Where(x => x.GetId()==cell.GetId()).FirstOrDefault();
            return newCell.IsOpen();
        }

        public void Mark(ICell cell)
        {
             var newCell = cells.Where(x => x.GetId()==cell.GetId()).FirstOrDefault();
            newCell.Mark();
        }

        public void MarkAsExploded(ICell cell)
        {
            var newCell = cells.Where(x => x.GetId()==cell.GetId()).FirstOrDefault();
            newCell.MarkAsExploded();
        }

        public void MarkAsOpen(ICell cell)
        {
            var newCell = cells.Where(x => x.GetId()==cell.GetId()).FirstOrDefault();
            newCell.MarkAsOpen();
            if(associatedLists.ContainsKey(newCell.GetId()))
            {
                foreach(var cell1 in associatedLists[newCell.GetId()])
                {
                    cell1.MarkAsOpen();
                }
            }
        }

    }
}