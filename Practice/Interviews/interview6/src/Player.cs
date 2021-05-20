using System.Collections.Generic;
using interview6.Interfaces;
public class Player : IPlayer
{
    private string name;
    private int id;
    private Queue<int> moves;
    private int currentPostion;
    private bool isWinner;
    public Player(int id, string name, int currentPostion, bool isWinner)
    {
        this.currentPostion  = currentPostion;
        this.name = name;
        this.id = id;
        this.isWinner = isWinner;
        moves = new Queue<int>();
        moves.Enqueue(currentPostion);
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
    public IEnumerable<int> GetMoves()
    {
        return moves;
    }
    public string GetName()
    {
        return name;
    }
    public IPlayer UpdateCurrentPosition(int newPosition)
    {
        moves.Enqueue(newPosition);
        return new Player(this.id, this.name, newPosition, this.isWinner);
    }
}