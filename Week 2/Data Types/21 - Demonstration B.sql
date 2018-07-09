-- Demonstration B

-- Step 1:
-- Switch the query window to use your copy of the AdventureWorksLT database

-- Step 2: Use collation in a query
SELECT CustomerId, LastName 
FROM SalesLT.Customer
WHERE LastName COLLATE Latin1_General_CS_AS = N'Miller';

-- Step 3a: Use a case sensitive collation in a query
SELECT CustomerId, LastName 
FROM SalesLT.Customer
WHERE LastName COLLATE Latin1_General_BIN = N'miller';
-- NOTE: this will return no results

-- Step 3b:
SELECT CustomerId, LastName 
FROM SalesLT.Customer
WHERE LastName COLLATE Latin1_General_BIN = N'Miller';
-- NOTE: the change in this query from the previous query is the case of the search term

-- Step 4: Using the CONCAT function to join strings
SELECT CustomerId, FirstName, MiddleName, LastName, 
CONCAT(LastName, N', ' + FirstName, N' ', MiddleName) AS FullName
FROM SalesLT.Customer;

-- Step 5: Use concatenation with + (plus) in a query
SELECT CustomerId, FirstName, MiddleName, LastName, 
FirstName + N' ' + LastName AS FullName
FROM SalesLT.Customer;

-- Step 6: Use string functions in a query
-- FORMAT
DECLARE @m money = 120.595
SELECT @m AS unformatted_value, 
FORMAT(@m,'C','zh-cn') AS zh_cn_currency,
FORMAT(@m,'C','en-us') AS en_us_currency,
FORMAT(@m,'C','de-de') AS de_de_currency;
-- end FORMAT example

SELECT SUBSTRING('Microsoft SQL Server',11,3) AS Result;
SELECT LEFT('Microsoft SQL Server',9) AS left_example, RIGHT('Microsoft SQL Server',6) as right_example;

SELECT LEN('Microsoft SQL Server     ') AS [LEN];
SELECT DATALENGTH('Microsoft SQL Server     ') AS [DATALENGTH];

SELECT CHARINDEX('SQL','Microsoft SQL Server') AS Result;

SELECT REPLACE('Learning about T-SQL string functions','T-SQL','Transact-SQL') AS Result;

SELECT UPPER('Microsoft SQL Server') AS UP, LOWER('Microsoft SQL Server') AS LOW;

-- Step 7: Use the LIKE predicate in a query - the % (percent) character
SELECT AddressID, CountryRegion
FROM SalesLT.Address
WHERE CountryRegion LIKE N'United%'

