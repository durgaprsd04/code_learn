namespace interview6.Interfaces
{
    interface ISnakevsLadder
    {
        public IPlayer GamePlay(IPlayer player, int diceValue);
        public IPlayer Play();
    }
}