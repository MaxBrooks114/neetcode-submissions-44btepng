public class Solution {
    public int MissingNumber(int[] nums) {
        var sumI = 1;
        var sum1 = 1;

        for(var i = 0; i < nums.Length; i++)
        {
            sumI+=(i+1);
            sum1+=(nums[i]);
        }

        return sumI-sum1;
    }
}
