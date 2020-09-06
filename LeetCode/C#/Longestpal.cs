using System;
namespace LeetCode{
public class Solution3 {
    public string LongestPalindrome(string s) {

      var len = s.Length;
      var charArray = s.ToCharArray();
      int tempi=0,tempj=0;
      string maxPal=string.Empty;
      for(int i=0;i<len-1;i++)
      {
        if(maxPal.Length>(Math.Abs(len-i-1)+1))
            break;
        for(int j=len-1;j>=i;j--)
        {
            if(charArray[i]==charArray[j])
            {
                tempi=i;
                tempj=j;
                while(tempi<tempj)
                {
                  //Console.WriteLine($"i {i} j {j} c {charArray[i]} ");
                  if(charArray[++tempi]==charArray[--tempj])
                  {
                    ///Console.WriteLine($" tempi {tempi} tempj{tempj}");
                    if(tempi==tempj ||(Math.Abs(tempi-tempj)==1))
                      if((Math.Abs(i-j)+1)>maxPal.Length)
                          maxPal= s.Substring(i,Math.Abs(i-j)+1);
                    ///Console.WriteLine(maxPal);
                  }
                  else
                  {
                    break;
                  }
                }
            }
        }
      }
      if(maxPal.Length==0)
        if(s.Length>0)
          maxPal=charArray[0].ToString();

      Console.WriteLine(maxPal);
    return maxPal;
    }
}
}
