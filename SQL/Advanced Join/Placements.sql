SELECT st.Name
FROM Friends
JOIN Students st ON st.ID = Friends.ID
JOIN Packages p1 ON p1.ID = Friends.ID
JOIN Packages p2 ON p2.ID = Friends.Friend_ID
WHERE p2.Salary > p1.Salary
ORDER BY p2.Salary