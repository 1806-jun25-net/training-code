-- this is a comment

-- most basic select statement
--   columns
--                table
SELECT * FROM SalesLT.Customer;

-- select only some columns, with aliasing
SELECT CustomerID AS ID, FirstName AS 'First Name', LastName AS 'Last Name'
FROM SalesLT.Customer;

-- select with where clause (filters rows on condition)
SELECT CustomerID, FirstName, LastName
FROM SalesLT.Customer
WHERE FirstName = 'Donna';

-- string ordering/comparison
SELECT CustomerID, FirstName, LastName
FROM SalesLT.Customer
WHERE FirstName < 'B';

-- with group by
-- first names, and how many duplicates they have
-- (for first names starting with A)
SELECT FirstName, COUNT(FirstName) AS 'Number of Duplicates'
FROM SalesLT.Customer
WHERE FirstName < 'B'
GROUP BY FirstName;

-- having clause (get rid of the ones with only one case)
SELECT FirstName, COUNT(FirstName) AS 'Number of Duplicates'
FROM SalesLT.Customer
WHERE FirstName < 'B'
GROUP BY FirstName
HAVING COUNT(FirstName) > 1;

-- sort them by count, descending
SELECT FirstName, COUNT(FirstName) AS 'Number of Duplicates'
FROM SalesLT.Customer
WHERE FirstName < 'B'
GROUP BY FirstName
HAVING COUNT(FirstName) > 1
ORDER BY COUNT(FirstName) DESC;