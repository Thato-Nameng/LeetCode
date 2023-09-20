public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] words = s.Split(' ');

        if (pattern.Length != words.Length)
            return false;
        
        for (int i = 0; i < pattern.Length; i++) {
             char c = pattern[i];
            string word = words[i];

            for (int j = i + 1; j < pattern.Length; j++) {
                if (pattern[j] == c && words[j] != word)
                    return false;
                if (pattern[j] != c && words[j] == word)
                    return false;
            }        
        }
                
        return true;               
    }
    
    
    
}