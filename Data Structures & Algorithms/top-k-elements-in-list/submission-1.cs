public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freq = new Dictionary<int, int>();
        var ans = new int[k];

        foreach(var num in nums)
        {
            freq[num] = freq.GetValueOrDefault(num)+1;

        }


        return freq.Keys.OrderByDescending(x => freq[x]).Take(k).ToArray();


    }
}
