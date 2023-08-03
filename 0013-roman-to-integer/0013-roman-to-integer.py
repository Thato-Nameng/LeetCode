class Solution(object):
    def romanToInt(self, s):
        romanArr = {'I' : 1, 'V' : 5, 'X' : 10, 'L' : 50, 'C' : 100, 'D' : 500, 'M' : 1000 }
        tot = 0
        oTot = 0      
    
        """
        :type s: str
        :rtype: int
        """
        for i in s[::-1]:
            val = romanArr[i]
            if val >= oTot:
                tot += val
            else:
                tot -= val
            oTot = val

        return tot


