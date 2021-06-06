using System;

namespace mineSweeper
{
    public interface IInput
    {
        public ICell GetCellFromInput();
        public string GetCommand();
    }
}