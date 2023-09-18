public class Solution {
    public string IntToRoman(int num) {
        string[] Roman = {
            "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"
        };                      
        int[] numerals = {
            1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1        
        };        
        string romanNumber = "";
        int i = 0;        
        do{
            while(num >= numerals[i]){
                romanNumber += Roman[i];
                num -= numerals[i];
            }
            i++;
        }while(num > 0);
        
        return romanNumber;
    }
}