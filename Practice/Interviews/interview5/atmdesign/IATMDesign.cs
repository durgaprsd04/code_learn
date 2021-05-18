using System.Collections.Generic;
public interface IDenomination
{
    public int GetValue();
    public string GetKey();
}
public interface IATMDesign
{
    public IATMDesign Dispense(int amount);
    public IATMDesign FillAtm(IList<IDenomination> denominations,  Dictionary<string, int> refill);
}