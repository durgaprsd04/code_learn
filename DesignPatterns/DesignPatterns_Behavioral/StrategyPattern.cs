using System;
using System.Collections.Generic;
public abstract class SortingStrategy
{
    protected List<string> _names = new List<string> ();
    public abstract void Sort(List<string> names);
}
public class QuickSort:SortingStrategy
{
   
    public override void Sort(List<string> names)
    {
        _names=names;
        //_names.QuickSort();
        Console.WriteLine("QuickSort implemented ");
    }
}
public class ShellSort:SortingStrategy
{
   
    public override void Sort(List<string> names)
    {
        _names=names;
        //_names.ShellSort();
        Console.WriteLine("ShellSort implemented ");
    }
}
public class MergeSort:SortingStrategy
{
    public override void Sort(List<string> names)
    {
        _names=names;
        //_names.MergeSort();
        Console.WriteLine("MergeSort implemented ");
    }
}
public class SortedList
{
    private SortingStrategy _sortingStrategy;
    private List<string> _names = new List<string>();
    public void SetSortStrategy(SortingStrategy  strategy)
    {
        this._sortingStrategy=strategy;
    }
    public void Add(string name)
    {
        _names.Add(name);
    }
    public void Sort()
    {
       _sortingStrategy.Sort(_names);
    }
}