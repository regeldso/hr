--Select Only Dates, Ordered by Datefiff, StartDate
SELECT StartDate, EndDate
FROM 
(
        -- Get  DateDiff of Alone Nodes
        (SELECT StartDate, EndDate, ABS(DateDiff(day,StartDate, EndDate)) as DD
        FROM
        (
            --SELECT Alone Nodes with JOIN
            SELECT t1.Start_Date as StartDate, t1.End_Date as EndDate, t1.Task_ID as ID, 
            CASE    
            WHEN t3.Task_ID IS NULL AND t2.Task_ID IS NULL THEN 'NODE'    
            ELSE NULL
            END Type1
        FROM Projects t1
        LEFT JOIN Projects t2 ON t2.Start_Date = t1.End_Date
        LEFT JOIN Projects t3 ON t3.End_Date = t1.Start_Date) AloneNodes
        WHERE AloneNodes.Type1 = 'NODE')
    --Union Begin & End Dates of Trees And Alone Nodes  
    UNION ALL
    (
        -- Join Only Begin and End of Trees By Rank   
        SELECT RnkByBegins.StartDate, RnkByEnds.EndDate, ABS(DateDiff(day,RnkByBegins.StartDate, RnkByEnds.EndDate)) as DD
        FROM 
        --Rank by Begin     
        (SELECT BeginOfNodes.StartDate, RANK() OVER 
            (PARTITION BY BeginOfNodes.Type1 ORDER BY StartDate) AS Rank
        FROM
        --SELECT Begin of Nodes with JOIN 
        (SELECT t1.Start_Date as StartDate, t1.End_Date as EndDate, t1.Task_ID as ID, 
            CASE
            WHEN t2.Task_ID IS NOT NULL AND t3.Task_ID IS NULL THEN 'BEGIN'   
            ELSE NULL
            END Type1
        FROM Projects t1
        LEFT JOIN Projects t2 ON t2.Start_Date = t1.End_Date
        LEFT JOIN Projects t3 ON t3.End_Date = t1.Start_Date) BeginOfNodes
        WHERE BeginOfNodes.Type1 = 'BEGIN') RnkByBegins
        JOIN 
        --Rank by Ends
        (SELECT EndsOfNodes.EndDate as EndDate, RANK() OVER 
            (PARTITION BY Type1 ORDER BY EndDate ASC) AS Rank
        FROM
         --SELECT End of Nodes with JOIN 
        (SELECT t1.Start_Date as StartDate, t1.End_Date as EndDate, t1.Task_ID as ID, 
            CASE
            WHEN t3.Task_ID IS NOT NULL AND t2.Task_ID IS NULL THEN 'END'  
            ELSE NULL
            END Type1
        FROM Projects t1
        LEFT JOIN Projects t2 ON t2.Start_Date = t1.End_Date
        LEFT JOIN Projects t3 ON t3.End_Date = t1.Start_Date) EndsOfNodes
        WHERE EndsOfNodes.Type1 = 'END') RnkByEnds
        ON RnkByBegins.Rank = RnkByEnds.Rank
    )
) FinalTable
ORDER BY DD, StartDate