class Solution(object):
    def mergeAlternately(self, word1, word2):
        nValue = ''
        merg_Val = min(len(word1), len(word2))        
        
        
        """
        :type word1: str
        :type word2: str
        :rtype: str
        """

        for i in range(merg_Val):
            nValue += word1[i] + word2[i]
        
        if len(word1) > merg_Val:
            nValue += word1[merg_Val:]

        if len(word2) > merg_Val:
            nValue += word2[merg_Val:]

        return nValue