class Solution(object):
    def letterCombinations(self, digits):
        """
        :type digits: str
        :rtype: List[str]
        """
        #if digits is empty return empty str
        if not digits:
            return []
        else:
            arrDigit = {
                '2': "abc", '3': "def", '4': "ghi",
                '5': "jkl", '6': "mno", '7': "pqrs",
                '8': "tuv", '9': "wxyz"
            }

            arrCom = ['']

            for i in digits:
                arrTemp = []
                for x in arrDigit[i]:
                    for y in arrCom:
                        arrTemp.append(y + x)
                arrCom = arrTemp

            return arrCom
                      