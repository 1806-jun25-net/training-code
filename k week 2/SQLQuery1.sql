-- this is a comment

-- most basic select statement
--  columns
--                 table
SELECT * FROM SalesLT.Customer;



SELECT CustomerID AS ID, FirstName AS 'First Name', LastName AS 'Last Name'
FROM SalesLT.Customer;


-- Select with where clause (filters rows on condition)
SELECT CustomerID, FirstName, LastName
FROM SalesLT.Customer
WHERE FirstName = "Donna";


-- String ordering/comparison
SELECT FirstName, COUNT(FirstName)
FROM SalesLT.Customer
WHERE FirstName < 'B';


-- With group by
-- first names, and how many duplicates they have (for first names starting with'A')
SELECT FirstName, COUNT(FirstName) AS 'Number of duplicates'
FROM SalesLT.Customer
WHERE FirstName < 'B'
GROUP BY FirstName
HAVING COUNT(FirstName) > 1
ORDER BY COUNT(FirstName) DESC;