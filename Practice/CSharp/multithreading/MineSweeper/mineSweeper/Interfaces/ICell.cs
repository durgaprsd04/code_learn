using System;

namespace mineSweeper
{
    public interface ICell
    {
        public void Mark();
        public void MarkAsExploded();
        public void MarkAsOpen();        
        public bool isExploded();
        public bool IsMarked();
        public bool IsOpen();
        public bool IsMine();
        public int GetId();
    }
}
