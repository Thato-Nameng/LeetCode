/* Write your T-SQL query statement below */
SELECT tweet_id
FROM Tweets
Where len(content) > 15;