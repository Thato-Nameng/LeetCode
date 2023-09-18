public class Solution {
    public string IntToRoman(int num) {
        string[] romanSymbols = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
        int[] symbolValues = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
        
        string result = "";
        int i = 0;
        
        do {
            while (num >= symbolValues[i]) {
                result += romanSymbols[i];
                num -= symbolValues[i];
            }
            i++;
        } while (num > 0);
        
        return result;
    }
}