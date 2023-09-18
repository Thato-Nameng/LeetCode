public class Solution {
    
 private string[] lower20 = new string[] {
        "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", 
        "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", 
        "Seventeen", "Eighteen", "Nineteen"
    };

    private string[] tens = new string[] {
        "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
    };

    private string[] thousands = new string[] {
        "", "Thousand", "Million", "Billion"
    };
    
    
    public string NumberToWords(int num) {
        if (num == 0) return lower20[0];

        string result = "";
        for (int i = 0; num > 0; i++, num /= 1000) {
            if (num % 1000 != 0)
                result = ConvertUpTo100(num % 1000) + thousands[i] + " " + result;
        }

        return result.Trim();
    }

    private string ConvertUpTo100(int num) {
        if (num == 0) return "";
        else if (num < 20) return lower20[num] + " ";
        else if (num < 100) return tens[num / 10] + " " + ConvertUpTo100(num % 10);
        else return lower20[num / 100] + " Hundred " + ConvertUpTo100(num % 100);
    }
}