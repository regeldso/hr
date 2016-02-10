SELECT CASE
           WHEN g.Grade > 7 THEN s.Name
           ELSE NULL
       END AS Name,
       g.Grade,
       s.Marks
FROM Students s
JOIN Grades g ON Marks BETWEEN g.Min_Mark AND g.Max_Mark
ORDER BY g.Grade DESC, Name, s.Marks