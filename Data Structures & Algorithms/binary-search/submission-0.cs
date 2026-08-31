public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int r = nums.Length - 1;

        if (nums[l] == target) return l;
        if (nums[r] == target) return r;

        while (l <= r) {
            int m = l + (r - l) / 2;

            if (nums[m] == target) return m;
            else if (nums[m] < target) l = m + 1;
            else r = m - 1; 
        }

        return -1;
    }
}
