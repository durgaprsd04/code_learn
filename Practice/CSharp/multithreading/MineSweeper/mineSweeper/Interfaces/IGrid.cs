using System;

namespace mineSweeper
{
    public interface IGrid
    {
        public void Mark(ICell cell);
        public void MarkAsExploded(ICell cell);
         public void MarkAsOpen(ICell cell);        
        public bool isExploded(ICell cell);
        public bool IsMarked(ICell cell);
        public bool IsOpen(ICell cell);
        public bool IsMine(ICell cell);
    }
}