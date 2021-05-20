using interview6.Interfaces;
public class VacantColumnType:IColumnType
{
    private int position;
    public int GetNextPosition()
    {
        return position;
    }
}