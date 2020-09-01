using System;
using System.Collections;
namespace DesignPatterns_Behavioral
{
    interface AbstractCollection
    {
        Iterator GetIterator();
        
    }
    public class Collection:AbstractCollection
    {
        private ArrayList _items = new ArrayList();
        public Iterator GetIterator()
        {
            return new Iterator(this);
        }
        public int Count()
        {
            return _items.Count;
        }
        public object this[int index]
        {
            get {return _items[index];}
            set {_items.Add(value);}
        }
    }
    public class Item
    {
        private string _name;
        // Constructor
        public Item(string name)
        {
            this._name = name;
        }
        public string Name
        {
       get { return _name; }
        }
    }
    interface IIterator
    {
        Item Next();
        Item First();
        bool isDone();
        Item CurrentItem();
    }
    public class Iterator:IIterator
    {
        private Collection collection;
        private int _current=0;
        private int _step=1;
        public Iterator(Collection collection)
        {
            this.collection=collection;
        }
        public Item Next()
        {
            _current =_current+_step;
            return new Item(collection[_current].ToString());
        }
        public int Step{
            set{_step=value;}
            get{return _step;}
        }
        public Item First()
        {
            _current=0;
            return new Item( collection[_current].ToString()) ;
        }
        public Item CurrentItem()
        {
            return new Item(collection[_current].ToString());
        }
        public bool isDone()
        {
            return _current>=collection.Count();
        }
    }
}