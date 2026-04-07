public class Solution {
    public bool hasDuplicate(int[] nums) {
        var hashSet = new HashSet<int>();

        foreach(var num in nums)
        {
            if(hashSet.Add(num))
                continue;
            return true;
        }


        return false;
    }
}