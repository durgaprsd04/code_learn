using System;

namespace mineSweeper
{
    public interface ICommand
    {
       public ICell Execute();
       public ICell Undo();
    }
}