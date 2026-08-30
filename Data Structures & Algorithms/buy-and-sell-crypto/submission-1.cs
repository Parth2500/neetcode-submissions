public class Solution {
    public int MaxProfit(int[] prices) {
        int l = prices.Length;
        if (l <= 1) return 0;

        int iBuy = 0;
        int iSell = 1;
        int maxProfit = 0;

        while (iBuy < iSell && iBuy <= l - 2 && iSell <= l - 1) {
            if (prices[iBuy] >= prices[iSell]) {
                iBuy = iSell;
            }
            else {
                int diff = prices[iSell] - prices[iBuy];
                if (diff > maxProfit) {
                    maxProfit = diff;
                }
            }

            iSell++;
        }

        return maxProfit;
    }
}
