using System.Linq;
using System.Text;
using System.Collections.Generic;
namespace Tries
{
    public class Trie
    {
        public char ch;
        public bool isWord;
        public Trie [] letterList;
        public Trie()
        {
            letterList = new Trie[26]; 
        }
        public Trie(string str)
        {
            letterList = new Trie[26]; 
            if(!string.IsNullOrEmpty(str))
            {
                this.ch =str[0];
                if(str.Length==1)
                {
                    isWord=true;
                }
                if(str.Length>1)
                {
                   if(letterList[str[0]-97] ==null)
                        letterList[str[0]-97] = new Trie(str.Substring(1, str.Length-1));
                    else
                        letterList[str[0]-97].Add(str.Substring(1, str.Length-1));
                }
                else
                    letterList[str[0]-97] = new Trie(){ch=str[0]};
            }
        }
        public void Add(string str)
        {
            if(!string.IsNullOrEmpty(str))
            {
                if(str.Length==1)
                    isWord=true;
                if(str.Length>1)
                {
                    if(letterList[str[0]-97] ==null)
                        letterList[str[0]-97] = new Trie(str.Substring(1, str.Length-1));
                    else
                        letterList[str[0]-97].Add(str.Substring(1, str.Length-1));
                }
                else
                    letterList[str[0]-97] = new Trie(){ch=str[0]};
            }
        }
        public List<string> GetWords()
        {
            var list = new List<string>();
            foreach(var smallTrie in letterList)
            {
                if(smallTrie!=null)
                {
                    var result = smallTrie.GetWords();
                    if(char.IsLetter(ch))
                        {
                            
                            foreach(var str in result )
                            {
                                var sb  = new StringBuilder(ch);
                                result.Add(str);
                            }
                        }
                }
            }
            return list;
        }
    }
}