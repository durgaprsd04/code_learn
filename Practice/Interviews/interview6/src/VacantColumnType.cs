using interview6.Interfaces;
public class VacantColumnType:IColumnType
{
    private int position;
    public VacantColumnType(int position)
    {
        this.position = position;
    }
    public int GetNextPosition()
    {
        return position;
    }
}