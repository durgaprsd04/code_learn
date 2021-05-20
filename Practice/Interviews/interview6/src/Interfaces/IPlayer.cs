using System.Collections.Generic;
namespace interview6.Interfaces
{
    public interface IPlayer
    {
        public string GetName();
        public int GetCurrentPosition();
        public IPlayer UpdateCurrentPosition(int n);
        public void SetWinner();
        public bool IsWinner();

        public IEnumerable<int> GetMoves();

    }
}