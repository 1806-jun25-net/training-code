-- Demonstration B

-- Step 1: Open a new query window to the TSQL database
USE TSQL;
GO

-- Step 2: Create a table to support the demonstrations
-- Clean up if the tables already exists
IF OBJECT_ID('dbo.SimpleOrderDetails','U') IS NOT NULL
	DROP TABLE dbo.SimpleOrderDetails;
IF OBJECT_ID('dbo.SimpleOrders','U') IS NOT NULL
	DROP TABLE dbo.SimpleOrders;
GO
CREATE TABLE dbo.SimpleOrders(
	orderid int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	custid int NOT NULL FOREIGN KEY REFERENCES Sales.Customers(custid),
	empid int NOT NULL FOREIGN KEY REFERENCES HR.Employees(empid),
	orderdate datetime NOT NULL
);
GO
CREATE TABLE dbo.SimpleOrderDetails(
	orderid int NOT NULL FOREIGN KEY REFERENCES dbo.SimpleOrders(orderid),
	productid int NOT NULL FOREIGN KEY REFERENCES Production.Products(productid),
	unitprice money NOT NULL,
	qty smallint NOT NULL,
 CONSTRAINT PK_OrderDetails PRIMARY KEY (orderid, productid)
);
GO

-- Step 3: Create a transaction to wrap around insertion statements
-- to create a single unit of work
BEGIN TRY
	BEGIN TRANSACTION
		INSERT INTO dbo.SimpleOrders(custid, empid, orderdate) VALUES (68,9,'2006-07-12');
		INSERT INTO dbo.SimpleOrderDetails(orderid,productid,unitprice,qty) VALUES (1, 2,15.20,20);
	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	SELECT ERROR_NUMBER() AS ErrNum, ERROR_MESSAGE() AS ErrMsg;
	ROLLBACK TRANSACTION
END CATCH;

-- Step 4: Verify success
SELECT  orderid, custid, empid, orderdate
FROM dbo.SimpleOrders;
SELECT  orderid, productid, unitprice, qty
FROM dbo.SimpleOrderDetails;

-- Step 5: Clear out rows from previous tests
DELETE FROM dbo.SimpleOrderDetails;
GO
DELETE FROM dbo.SimpleOrders;
GO

--Step 6: Execute with errors in data to test transaction handling
BEGIN TRY
	BEGIN TRANSACTION
		INSERT INTO dbo.SimpleOrders(custid, empid, orderdate) VALUES (68,9,'2006-07-15');
		INSERT INTO dbo.SimpleOrderDetails(orderid,productid,unitprice,qty) VALUES (99, 2,15.20,20);
	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	SELECT ERROR_NUMBER() AS ErrNum, ERROR_MESSAGE() AS ErrMsg;
	ROLLBACK TRANSACTION
END CATCH;

-- Step 7: Verify that no partial results remain
SELECT  orderid, custid, empid, orderdate
FROM dbo.SimpleOrders;
SELECT  orderid, productid, unitprice, qty
FROM dbo.SimpleOrderDetails;


-- Step 8: Clean up demonstration tables
IF OBJECT_ID('dbo.SimpleOrderDetails','U') IS NOT NULL
	DROP TABLE dbo.SimpleOrderDetails;
IF OBJECT_ID('dbo.SimpleOrders','U') IS NOT NULL
	DROP TABLE dbo.SimpleOrders;
