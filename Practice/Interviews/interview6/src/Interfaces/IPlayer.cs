namespace interview6.Interfaces
{
    public interface IPlayer
    {
        public int GetCurrentPosition();
        public IPlayer UpdateCurrentPosition(int n);
        public void SetWinner();
        public bool IsWinner();

    }
}