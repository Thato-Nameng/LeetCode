public class Solution {
    public int RomanToInt(string s) {
        int result = 0;
        int i = 0;
        
        do{
            int cValue = GetValue(s[i]);
            int next = 0;
            
            if (i < s.Length - 1){
                next = GetValue(s[i + 1]);
            }
            
            if (cValue < next){
                result -= cValue;
            }
            else{
                result += cValue;
            }
            i++;        
        }while (i < s.Length);
        return result;
    }
     
    private static int GetValue(char romanChar)
    {      
        if (romanChar == 'I') 
            return 1;
        else if (romanChar == 'V') 
            return 5;
        else if (romanChar == 'X') 
            return 10;
        else if (romanChar == 'L') 
            return 50;
        else if (romanChar == 'C') 
            return 100;
        else if (romanChar == 'D') 
            return 500;
        else if (romanChar == 'M') 
            return 1000;
        else 
            throw new ArgumentException("Invalid Roman numeral");
    }
}