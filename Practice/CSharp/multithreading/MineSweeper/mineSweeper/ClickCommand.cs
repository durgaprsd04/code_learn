using System;
using System.Collections.Generic;
using System.Linq;

namespace mineSweeper
{
    public class ClickCommand : ICommand
    {
        private ICell cell;
        public ClickCommand(ICell cell)
        {
            this.cell = cell;
        }
        public ICell Execute()
        {
            cell.Open();
            return cell;
        }

        public ICell Undo()
        {
            throw new NotImplementedException();
        }
    }
}