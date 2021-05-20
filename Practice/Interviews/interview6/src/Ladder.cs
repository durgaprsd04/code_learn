using interview6.Interfaces;
public class Ladder:IColumnType
{
    public Ladder(int position , int rings)
    {
        this.position = position;
        this.rings = rings;
    }
    private int position;
    private int rings;
    public int GetNextPosition()
    {
        return position+ rings;
    }
}