public class Solution {
    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();

        foreach (string s in strs) {
            sb.Append(s.Length).Append('#').Append(s);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var result = new List<string>();

        int i = 0;
        while (i < s.Length) {
            int hi = s.IndexOf('#', i);
            int l = int.Parse(s.Substring(i, hi - i));
            
            result.Add(s.Substring(hi + 1, l));

            i = hi + l + 1;
        }

        return result;
    }
}
