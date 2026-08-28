public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var map = new Dictionary<int, int>();

        foreach (int n in nums) {
            if (!map.ContainsKey(n)) {
                map[n] = 0;
            }
            map[n]++;
        }
        
        List<int>[] buckets = new List<int>[nums.Length + 1];

        for (int i = 0; i < buckets.Length; i++) {
            buckets[i] = new List<int>();
        }

        foreach (var entry in map) {
            buckets[entry.Value].Add(entry.Key);
        }

        List<int> lst = new List<int>();

        for (int i = buckets.Length - 1; i >= 0 && lst.Count < k; i--) {
            foreach (int n in buckets[i]) {
                lst.Add(n);

                if(lst.Count == k) break;
            }
        }

        return lst.ToArray();
    }
}
