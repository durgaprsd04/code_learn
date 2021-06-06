using System;

namespace mineSweeper
{
    public interface ICommand
    {
       public IGrid Execute();
       public IGrid Undo();
       public ICell GetCell();
    }
}