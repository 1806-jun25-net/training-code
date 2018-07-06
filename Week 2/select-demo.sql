-- this is a comment

-- most basic select statement
--   columns
--                table
SELECT * FROM SalesLT.Customer;

-----------------------------------------------------------------------------------------------------------
--examples july 6
Select FirstName, LastName from SalesLT.Customer
where MiddleName is null or MiddleName = '';
-----------------------------------------------------------------------------------------------------------
select distinct firstname from saleslt.customer
where firstname in (select lastname from saleslt.customer);
-- for this to be the same you would need to use distinct in the first 
(select FirstName from SalesLT.Customer)
intersect
(select lastname from SalesLT.Customer);
--all 3 return the same
select distinct a.firstname from SalesLT.Customer as a
inner join SalesLT.Customer as b on a.firstname = b.LastName; 
-----------------------------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------------


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