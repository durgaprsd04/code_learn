using System;
using System.Collections.Generic;
using System.Linq;

namespace mineSweeper
{
    public class ClickCommand : ICommand
    {
        private IGrid  grid;
        private ICell cell;
        public ClickCommand(IGrid grid,  ICell cell)
        {
            this.grid = grid;
            this.cell = cell;
        }
        public IGrid Execute()
        {
            grid.MarkAsOpen(cell);
            return grid;
        }
        public ICell GetCell()
        {
            return cell;
        }
        public IGrid Undo()
        {
            throw new NotImplementedException();
        }
    }
}