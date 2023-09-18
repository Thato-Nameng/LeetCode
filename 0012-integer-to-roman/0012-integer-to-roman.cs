public class Solution {
    public string IntToRoman(int num) {
        string[] romanSymbols = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
        int[] values = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
        
        StringBuilder result = new StringBuilder();
        int i = 0;
        
        do {
            while (num >= values[i]) {
                result.Append(romanSymbols[i]);
                num -= values[i];
            }
            i++;
        } while (num > 0);
        
        return result.ToString();
    }
}