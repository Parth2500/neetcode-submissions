public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        int[] a = new int[26];

        for (int i = 0; i < s.Length; i++) {
            a[s[i] - 'a']++;
            a[t[i] - 'a']--;
        }

        foreach (int n in a) {
            if (n != 0) return false;
        }

        return true;
    }
}
