public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       
        var ans = new int[2];
  
        for(var i = 0; i < nums.Length; i++)
        {
           
            for(var j = i+1; j < nums.Length; j++)
            {
                if(nums[i] + nums[j] == target)
                {
                    ans[0] = i;
                    ans[1] = j;
                    return ans;
                }
            }

            
        }


        return ans;
    }
}
