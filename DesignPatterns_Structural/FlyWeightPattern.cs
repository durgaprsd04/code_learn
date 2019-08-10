using System;
using System.Collections;
using System.Collections.Generic;
public class CharacterFactory
{
    private Dictionary<char,Character> _charactorlist = new Dictionary<char, Character>();
    public Character character=null;
    public Character GetCharacter(char c)
    {
        if(!_charactorlist.ContainsKey(c))
        {
            switch(c)
            {
                case 'A': character= new CharacterA(); break;
                case 'B': character= new CharacterB(); break;
                case 'Z': character= new CharacterZ(); break;
            }
            _charactorlist.Add(c,character);
        }
        return _charactorlist[c];
    }
}
public abstract class Character
{
    protected int height;
    protected int weight;
    protected int width;
    protected int descent;
    protected int PointSize;
    public abstract void Display(int PointSize);
}
public class CharacterA : Character
{
    private char symbol;
    public CharacterA()
    {
        this.height=10;
    this.weight=20;
    this.width=30;
    this.descent=0;
    this.PointSize=0;
    this.symbol='A';
    }
    public override void Display(int PointSize)
    {
        this.PointSize=PointSize;
        Console.WriteLine(this.symbol +"(pointsize  "+PointSize +")");
    }
}


public class CharacterZ : Character
{   
    private char symbol;
    public CharacterZ(){

    this.height=10;
    this.weight=40;
    this.width=40;
    this.descent=0;
    this.PointSize=0;
    this.symbol='Z';
    }
    
    public override void Display(int PointSize)
    {
        this.PointSize=PointSize;
        Console.WriteLine(this.symbol +"(pointsize  "+PointSize +")");
    }
}


public class CharacterB : Character
{
    private char symbol;
    public CharacterB()
    {
    this.height=10;
    this.weight=40;
    this.width=35;
    this.descent=0;
    this.PointSize=0;
    this.symbol='B';
    }
    
    public override void Display(int PointSize)
    {
        this.PointSize=PointSize;
        Console.WriteLine(this.symbol +"(pointsize  "+PointSize +")");
    }
}