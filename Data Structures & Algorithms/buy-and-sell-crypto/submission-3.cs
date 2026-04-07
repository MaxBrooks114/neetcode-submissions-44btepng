public class Solution {
    public int MaxProfit(int[] prices) {
        var profit = 0;
        var l = 0;
        var r = 1;
        while(r < prices.Length)
        {
            if(prices[l] < prices[r])
            {
                profit = Math.Max(profit, prices[r]-prices[l]);
               
            }
            else
            {
                l=r;
            }
            r++;
        }

        return profit;
    }
}
