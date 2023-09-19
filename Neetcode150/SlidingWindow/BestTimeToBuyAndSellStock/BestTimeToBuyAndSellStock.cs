public class Solution {
    public int MaxProfit(int[] prices) {
        var l = 0;
        var maxProfit = 0;

        for (int r = 0; r < prices.Length; r++) {
            maxProfit = Math.Max(maxProfit, (prices[r] - prices[l]));

            if (prices[r] < prices[l]) {
                l = r;
            }
        }

        return maxProfit;
    }
}
