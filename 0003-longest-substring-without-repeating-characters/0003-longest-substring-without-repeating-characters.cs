public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int x = s.Length;
        int tot = 0;
        int[] Index = new int[128];
        
        for (int j = 0, i = 0; j < x; j++)
        {
            i = Math.Max(Index[s[j]], i);
            int newTot = j - i + 1;
            tot = Math.Max(tot, newTot);
            Index[s[j]] = j + 1;
        }
        return tot;
    }
}