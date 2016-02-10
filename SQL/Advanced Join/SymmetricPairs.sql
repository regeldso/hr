SELECT TOP 50 PERCENT t1.X, t1.Y
FROM Functions t1
JOIN Functions t2 ON t2.X = t1.Y AND t2.Y = t1.X 
WHERE  t1.X <> t1.Y OR (SELECT Count(*) FROM Functions t3 WHERE t3.Y = t1.Y AND t3.X = t1.X) > 1
GROUP BY  t1.X,  t1.Y
ORDER BY t1.X