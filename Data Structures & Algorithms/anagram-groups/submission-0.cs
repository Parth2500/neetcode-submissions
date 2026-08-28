public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if (strs.Length <= 1) return new List<List<string>>() {strs.ToList()};

        var map = new Dictionary<string, List<string>>();

        foreach (string str in strs) {
            int[] arr = new int[26];

            for (int i = 0; i < str.Length; i++) {
                arr[str[i] - 'a']++;
            }

            string key = string.Join(',', arr);

            if (!map.ContainsKey(key)) {
                map.Add(key, new List<string>());
            }
            map[key].Add(str);
        }

        return map.Values.OrderBy(g => g.Count).Cast<List<string>>().ToList();
    }
}
