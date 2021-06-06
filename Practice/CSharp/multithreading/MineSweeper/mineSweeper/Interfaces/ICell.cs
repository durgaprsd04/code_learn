using System;

namespace mineSweeper
{
    public interface ICell
    {
        public void Mark();
        public void MarkAsExploded();
        public bool isExploded();
        public bool IsMarked();
        public bool IsOpen();
        public bool IsMine();
        public int GetCol();
        public int GetRow();
        public int GetNearByMines();
        public int GetId();

        public void Open();
    }
}
