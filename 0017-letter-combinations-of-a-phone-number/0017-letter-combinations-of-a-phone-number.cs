public class Solution {
    public IList<string> LetterCombinations(string digits) {
        if (string.IsNullOrEmpty(digits)) return new List<string>();
        
        Dictionary<char, string> arrDigit = new Dictionary<char, string>() {
            {'2', "abc"}, {'3', "def"}, {'4', "ghi"},
            {'5', "jkl"}, {'6', "mno"}, {'7', "pqrs"},
            {'8', "tuv"}, {'9', "wxyz"}
        };

        List<string> arrCom = new List<string>() {""};

        foreach (char digit in digits) {
            List<string> arrTemp = new List<string>();
            foreach (char x in arrDigit[digit]) {
                foreach (string y in arrCom) {
                    arrTemp.Add(y + x);
                }
            }
            arrCom = arrTemp;
        }

        return arrCom;
    }
}