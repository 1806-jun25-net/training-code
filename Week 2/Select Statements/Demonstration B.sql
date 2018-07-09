-- Demonstration B - Use the AdventureWorksLT database on SQL Azure

-- Step 1: Connect to the AdventureWorksLT database
-- The USE statement is not currently compatible with SQL Azure databases.
-- Instead, select AdventureWorksLT from the Available Databases list


-- Step 2: Include duplicate rows
-- Select and execute the following query to show duplicate rows 
-- returned from the SalesLT.Product table. You should see 295 rows.
SELECT Color, Size 
FROM SalesLT.Product;


-- Step 3: Filtering out duplicate rows
-- Select and execute the following query to show duplicate rows 
-- filtered from the SalesLT.Product table. You should see 68 rows.
SELECT DISTINCT Color, Size 
FROM SalesLT.Product;


-- Step 4: Select Disctinct
-- Select and execute the following query to show that DISTINCT across 
-- a column list that already includes a key will not filter duplicates. 
-- You should see 295 rows. 
-- Point out the orderid key column for the SalesLT.Product table in the Object Explorer.
-- You may want to show the same statement without DISTINCT, for comparison.
SELECT DISTINCT ProductID, Color, Size 
FROM SalesLT.Product;