public class Solution {
    public string AddBinary(string a, string b) {
        int x = a.Length -1;
        int y = b.Length -1;
        int binary = 0;
        string total = "";
        
        while (x >= 0 || y >= 0 || binary > 0){
            int sum = binary;
            
            if (x >= 0){
                sum += a[x] - '0';
                x--;
            }
            if (y >= 0){
                sum += b[y] - '0';
                y--;
            }
            total = (sum % 2) + total;
            binary = sum / 2;
        }
        
        return total;
    }
}