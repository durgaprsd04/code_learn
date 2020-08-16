using System.Collections.Generic;
public class Solution {
    List<int> listOfNums= new List<int>();
    int sum=0;
    public int[] RunningSum(int[] nums) {
        foreach(var e in nums)
        {
            sum+=e;
            listOfNums.Add(sum);
        }
      return listOfNums.ToArray();
    }
}
