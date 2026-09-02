public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int l = nums.Length;
        int[] pre = new int[l];
        pre[0] = nums[0];
        int[] post = new int[l];
        post[l - 1] = nums[l - 1];

        for (int i = 1, j = l - 2; i < l && j > -1; i++, j--)
        {
            if (nums[i] == 0 || pre[i - 1] == 0)
            {
                pre[i] = 0;
            }
            else
            {
                pre[i] = nums[i] * pre[i - 1];
            }

            if (nums[j] == 0 || post[j + 1] == 0)
            {
                post[j] = 0;
            }
            else
            {
                post[j] = nums[j] * post[j + 1];
            }
        }

        for (int i = 0; i < l; i++)
        {
            if (i == 0)
            {
                nums[i] = post[i + 1];
            }
            else if (i == l - 1)
            {
                nums[i] = pre[i - 1];
            }
            else
            {
                nums[i] = pre[i - 1] * post[i + 1];
            }
        }

        return nums;
    }
}
