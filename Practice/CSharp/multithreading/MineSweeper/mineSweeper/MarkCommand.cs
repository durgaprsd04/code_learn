using System;
using System.Collections.Generic;
using System.Linq;

namespace mineSweeper
{
    public class MarkCommand : ICommand
    {
        private IGrid grid;
        private ICell cell;
        public MarkCommand(IGrid grid,  ICell cell)
        {
            this.grid = grid;
            this.cell = cell;
        }
        public IGrid Execute()
        {
            grid.Mark(cell);
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