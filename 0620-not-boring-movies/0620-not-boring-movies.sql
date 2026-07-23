# Write your MySQL query statement below
SELECT *
FROM Cinema
WHERE description <> 'boring'
AND ID %2 !=0 -- (ID & 1) = 1
ORDER BY rating DESC