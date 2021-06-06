using System;

namespace mineSweeper
{
    public interface IUser
    {
        public ICommand GetInput(ICell cell);
        public int GetCellId();
    }
}