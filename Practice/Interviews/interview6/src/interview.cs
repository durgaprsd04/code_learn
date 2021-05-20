public class Test
{
    public int GetPos(int [] arr)
    {
        var prefix = new int[arr.Length];
        prefix[0] = arr[0];
        for(int i=1;i<arr.Length;i++)
            prefix[i] = prefix[i-1] + arr[i];
        // 1 6 9 15
        var len = prefix.Length;
        int pos =0;
        for(int i=1;i<arr.Length;i++)
        {
            if(prefix[i-1] == (prefix[len-1]-prefix[i])) 
            {
                pos=i;
                break;
            }
        }
        return pos;
    }

    //a[1] =a[1]
    //a[2] = a[1]+ a[2]
    // 1 6 9 15
    // prefix[len] - prefix[i] == prefix[i-1]
    // 15 - 6  == 1 (i-1==0)
    // 15 - 9 == 6 (i-1==1)
    
}