using System;
using System.Collections.Generic;
using System.Linq;

namespace mineSweeper
{
    public class MarkCommand : ICommand
    {
        private ICell cell;
        private List<ICell> cells ;
        private Dictionary<int, List<ICell>> associatedLists;
        public MarkCommand(ICell cell)
        {
            this.cell = cell;
        }
        public ICell Execute()
        {
            var id = cell.GetId();
            cells[id].Mark();
            return cells[id];
        }

        public ICell Undo()
        {
            throw new NotImplementedException();
        }
    }
}