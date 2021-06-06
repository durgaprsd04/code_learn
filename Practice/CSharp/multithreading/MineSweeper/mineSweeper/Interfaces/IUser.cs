using System;

namespace mineSweeper
{
    public interface IUser
    {
        public ICommand GetInput(IGrid grid);
        public ICell GetCell();
    }
}