Create Table Products(
ID Int Not Null,
Name NVarChar(20),
Price Float,
Constraint PK_Products Primary Key (ID));

Create Table Customers(
ID Int Not Null,
FirstName NVarChar(20),
LastName NVarChar(20),
CardNumber Int,
Constraint PK_Customers Primary Key (ID));

Create Table Orders(
ID Int Not Null,
ProductID Int Not Null,
CustomerID Int Not Null,
Constraint PK_Orders Primary Key (ID),
Constraint FK1_Orders Foreign Key (ProductID) References Products (ID),
Constraint FK2_Orders Foreign Key (CustomerID) References Customers (ID));

Insert into Products Values(1, 'iPhone', 200);
Insert into Products Values(2, 'Chair', 20);
Insert into Products Values(3, 'Fan', 15);

Insert into Customers Values(1, 'Tina', 'Smith', 12345);
Insert into Customers Values(2, 'Nick', 'Escalona', 54321);
Insert into Customers Values(3, 'Mr.', 'Robot', 11111);

Insert into Orders Values(1, 1, 1);
Insert into Orders Values(2, 2, 1);
Insert into Orders Values(3, 3, 3);

Select *
From Orders Inner Join Customers on Orders.CustomerID = Customers.ID
Where FirstName = 'Tina' AND LastName = 'Smith'

Select Sum(Price) as Revenue
From Products Inner Join Orders on Products.ID = Orders.ProductID
Where Name = 'iPhone'

Update Products
Set Price = 250
Where Name = 'iPhone'