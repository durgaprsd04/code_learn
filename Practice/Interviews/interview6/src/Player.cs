using interview6.Interfaces;
public class Player : IPlayer
{
    private string name;
    private int id;
    private int currentPostion;
    private bool isWinner;
    public Player(int id, string name, int currentPostion, bool isWinner)
    {
        this.currentPostion  = currentPostion;
        this.name = name;
        this.id = id;
        this.isWinner = isWinner;
    }

    public int GetCurrentPosition()
    {
        return currentPostion;
    }

    public bool IsWinner()
    {
        return isWinner;
    }
    public void SetWinner()
    {
        this.isWinner =true;
    }

    public IPlayer UpdateCurrentPosition(int newPosition)
    {
        return new Player(this.id, this.name, newPosition, this.isWinner);
    }
}