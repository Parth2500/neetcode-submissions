public class Solution {
    public bool hasDuplicate(int[] nums) {
        if (nums.Length <= 0) return false;
        var seen = new HashSet<int>();

        foreach (int n in nums) {
            if (!seen.Add(n)) return true;
        }

        return false;
    }
}