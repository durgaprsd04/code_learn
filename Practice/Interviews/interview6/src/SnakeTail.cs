using interview6.Interfaces;
public class SnakeTail:IColumnType
{
    public SnakeTail(int position , int tailLength)
    {
        this.position = position;
        this.tailLength = tailLength;
    }
    private int position;
    private int tailLength;
    public int GetNextPosition()
    {
        return position- tailLength;
    }
}