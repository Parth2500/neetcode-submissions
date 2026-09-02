public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int allProd = 1;
        List<int> z = new List<int>();

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) {
                z.Add(i);
            }
            else{
                allProd *= nums[i];
            }
        }

        int[] result = new int[nums.Length];

        if (z.Count == 0) {
            for (int i = 0; i < nums.Length; i++) {
                result[i] = allProd / nums[i];
            }
        }
        else if (z.Count == 1) {
            for (int i = 0; i < nums.Length; i++) {
                if (i == z[0]) {
                    result[i] = allProd;
                }
                else {
                    result[i] = 0;
                }
            }
        }
        else {
            for (int i = 0; i < nums.Length; i++) {
                result[i] = 0;
            }
        }        

        return result;
    }
}
