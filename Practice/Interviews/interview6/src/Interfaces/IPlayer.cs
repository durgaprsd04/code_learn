namespace interview6.Interfaces
{
    public interface IPlayer
    {
        public int rollDice(int n);
        public int GetCurrentPosition();
        public void UpdateCurrentPosition(int n);
        public void SetWinner();
        public bool IsWinner();

    }
}