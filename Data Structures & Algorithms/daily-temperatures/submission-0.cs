public class Solution {
    public int[] DailyTemperatures(int[] temps) {
        //in how many days will it be warmer than today?

        var ans = new int[temps.Length];
        var stack = new Stack<(int, int)>();
        
        for(var i = 0; i < temps.Length; i++)
        {
          
            while(stack.Count > 0 && stack.Peek().Item1 < temps[i])
            {
                var val = stack.Pop();
                ans[val.Item2] = i-val.Item2;
               
            }

            stack.Push((temps[i], i));
            
        }
     
        return ans;
    }
}
