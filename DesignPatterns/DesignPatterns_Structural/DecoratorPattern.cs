using System;
using System.Collections.Generic;
namespace DesignPatterns_Structural
{
    public abstract class Item 
    {
        private int _numCopies;
        public int NumCopies{
            set{_numCopies=value;}
            get{return _numCopies;}
        }
        public abstract void Display();
    }
    public class Book : Item{
        private string _author;
        private string _title;
        public Book(int copies, string author, string title)
        {
            NumCopies=copies;
            _author=author;
            _title=title;
        }
        public override void Display()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Author "+_author);
            Console.WriteLine("Tille  "+_title);
            Console.WriteLine("Number of copies "+NumCopies);
            Console.WriteLine("------------------");
        }
    }
    public class Video :Item
    {
        private string _director;
        private string _title;
        private string _duration;
        public Video(int numcopies, string title, string director, string duration  )
        {
            _duration=duration;
            _title=title;
            _director=director;
            this.NumCopies = numcopies;
        }
        public override void Display()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Title  "+_title);
            Console.WriteLine("Director  "+_director);
            Console.WriteLine("Duration "+_duration);
            Console.WriteLine("Number of copies "+NumCopies);
            Console.WriteLine("------------------");
        }
    }
    public class Decorator: Item
    {
        protected Item _libraryItem;
        public Decorator(Item item )
        {
            _libraryItem=item;
        }
        public override void Display()
        {
            _libraryItem.Display();
        }
    }
    public class Borrower: Decorator
    {
        private List<string> _borrowers= new List<string>();
        public Borrower(Item item):base(item)
        {

        }
        public void Borrow(string name)
        {
            _libraryItem.NumCopies--;
            _borrowers.Add(name);
        } 
        public void Return(string name)
        {
            _libraryItem.NumCopies++;
            _borrowers.Remove(name);
        }
        public override void Display()
        {
            base.Display();
            foreach(string borrower in _borrowers)
            {
                Console.WriteLine("Borrower name "+borrower);
            }
        }
    }
}