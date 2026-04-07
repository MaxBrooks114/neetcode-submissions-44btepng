public class Solution {
    public int SingleNumber(int[] nums) {
        var sel = 0;

        foreach(var num in nums)
        {
            sel^=num;
        }

        return sel;
    }
}
