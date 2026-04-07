public class Solution {
    public int[] PlusOne(int[] digits) {
        var s ="";

        foreach(var num in digits)
            s+=num.ToString();

        long n = 0;
        long.TryParse(s, out n);
       
        var list = new Stack<int>();

        n+=1;
        while(n >0)
        {
            var add = n%10;
           
            list.Push((int)add);
            n /= 10;
        }

        return list.ToArray();
        
        
    }
}
