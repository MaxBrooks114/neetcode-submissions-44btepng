public class Solution {
    public int MaxArea(int[] heights) {
        var maxArea = 0;

        var l = 0;
        var r = heights.Length-1;

        while(l < r)
        {
            var height = Math.Min(heights[l], heights[r]);

            var width = r-l;

            maxArea = Math.Max(maxArea, height * width);

            if(heights[l] < heights[r])
                l++;
            else
                r--;
        }

        return maxArea;
    }
}
