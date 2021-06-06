using System;
using System.Text;
using System.Collections.Generic;
namespace Trie
{
    public class Trie
    {
        char ch;
        public bool isEnd;
        public Trie [] children = new Trie[26];
        public Trie(char ch1)
        {
            this.ch = ch1;
        }
        public Trie()
        {
            ch = '$';
        }
        public void Add(string str)
        {
            var temp = this;
            foreach(char ch1 in str)
            {
                if(temp.children[ch1-'a'] == null)
                    temp.children[ch1-'a'] = new Trie(ch1);
                temp = temp.children[ch1-'a'];
            }
            temp.isEnd=true;
        }
        public void Print()
        {
            Print(new StringBuilder());
        }
        private void Print(StringBuilder sb)
        {
            foreach(var trie in children)
            {
                if(trie!=null)
                {
                    sb.Append(trie.ch);
                    if(trie.isEnd)
                        Console.WriteLine(sb.ToString());
                    trie.Print(new StringBuilder(sb.ToString()));
                    if(sb.Length>1)
                        sb.Remove(sb.Length-1, 1);
                }
            }
        }
        public bool LookUp(string str)
        {
            var temp = this;
            var flag = true;
            foreach(char ch1 in str)
            {
                if(temp.children[ch1-'a']==null)
                {
                    flag =false;
                    break;
                }
                else
                    temp = temp.children[ch1-'a'];
            }
            if(!temp.isEnd)
                flag=false;
            return flag;
        }
    }
}