SELECT * FROM SalesLT.Customer;
--
SELECT FirstName, LastName FROM SalesLT.Customer
WHERE MiddleName IS NULL OR MiddleName = '';
--
SELECT DISTINCT FirstName FROM SalesLT.Customer
WHERE FirstName IN (SELECT LastName FROM SalesLT.Customer);

SELECT FirstName FROM SalesLT.Customer
INTERSECT
SELECT LastName FROM SalesLT.Customer;

SELECT DISTINCT a.FirstName FROM SalesLT.Customer AS a
INNER JOIN SalesLT.Customer AS b ON a.FirstName = b.LastName;

