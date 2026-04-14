public class Solution {
    public int FindMin(int[] nums) {
        var l = 0;
        var r = nums.Length-1;
        var min = int.MaxValue;
        if(nums[0] < nums[r])
            return nums[0];
        else
        {
            int mid = l+((r-l)/2);
            if(nums[l] <= nums[mid])
            {
                l=mid+1;

            }
            else
                r=mid-1;
            min = Math.Min(nums[mid], min);
            while(l <= r)
            {
                mid = l+((r-l)/2);
                if(nums[mid] < min)
                {
                    min = nums[mid];
                    r--;
                }
                else 
                    l++;


            }
        }

        return min;
    }
}
