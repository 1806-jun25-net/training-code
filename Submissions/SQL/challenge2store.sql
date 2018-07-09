
--assignment two creating tables

CREATE TABLE Products (

ID int,
Name nvarchar,
Price decimal,
PRIMARY KEY (ID)

);



CREATE TABLE Customers(

ID int,
Firstname nvarchar,
Lastname nvarchar,
CardNumber int,
PRIMARY KEY (ID),

);

CREATE TABLE Orders (

ID int,
ProductID int,
CustomerID int,
PRIMARY KEY (ID),
FOREIGN KEY (ProductID) REFERENCES Products(ID),
FOREIGN KEY (CustomerID)REFERENCES Customers(ID)
);

--adding records


INSERT INTO Products
VALUES (1, 'Turkey', 5.00),
	(2, 'Brand new car', 300000.00),
	(3, 'iPhone', 200);

INSERT INTO Customers
VALUES (1, 'Tina', 'Smith', 123),
(2, 'John', 'Cena', 333),
(3, 'Fred', 'Littleton', 929);

INSERT INTO Orders
VALUES (1, 3, 1),  -- tina smith bought an iphone
(2, 2, 2),
(3, 3, 39);


--report all orders for tina smith

SELECT * FROM Orders
WHERE CustomerID = 1;

--all revenue from iPhone sales

SELECT * FROM Orders
WHERE ProductID = 3

--then relate to cost of that product by foreign key somehow


--increase the price of the iPhone to 250

UPDATE Products
SET Price = 250
WHERE ID = 3;

