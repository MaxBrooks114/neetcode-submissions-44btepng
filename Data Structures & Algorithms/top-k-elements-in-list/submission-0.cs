public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var map = new Dictionary<int, int>();
        var ans = new int[k];
        foreach(var num in nums)
        {
            map[num] = map.GetValueOrDefault(num)+1;
        }

       for(var i = 0; i < k; i++ )
       {
            var max =  map.Keys.MaxBy(x => map[x]);
            ans[i] = max;
            map[max] = -1;

       }

       return ans;
    }
}
