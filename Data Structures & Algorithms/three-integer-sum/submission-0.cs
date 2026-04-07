public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {

        var ans = new List<List<int>>();
        for(var i = 0; i < nums.Length; i ++)
        {
            for(var j = i+1; j < nums.Length; j++)
            {
                for(var k = j +1; k < nums.Length; k++)
                {
                    if(nums[i] + nums[j] + nums[k] == 0)
                    {
                        var add = new List<int>(){nums[i], nums[j], nums[k]}.OrderBy(x => x).ToList();
                        if(!ans.Any(x => x.SequenceEqual(add)))
                            ans.Add(add);
                    }
                }
            }
        }

        return ans;
    }
}
