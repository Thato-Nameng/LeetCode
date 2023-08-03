class Solution(object):
    def sumOfUnique(self, nums):
        
        """
        :type nums: List[int]
        :rtype: int
        """
        arrNum = []  
        for i in nums:
            if nums.count(i) == 1:
                arrNum.append(i)

        return sum(arrNum)
        
        