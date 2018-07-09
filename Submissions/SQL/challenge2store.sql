CREATE TABLE Orders
(ID int Identity(1,1), ProductID int, CustomerID int)

go
CREATE TABLE Products
(ID int Identity(1,1), Name NVARCHAR(128), Price decimal(13,2))

go 
CREATE TABLE Customers
(ID int Identity(1,1), Firstname NVARCHAR(128), Lastname NVARCHAR(128), CardNumber int)

ALTER TABLE Orders
ADD Primary Key (ID)

ALTER TABLE Products
ADD Primary Key (ID)

ALTER TABLE Customers
ADD Primary KEY (ID)

ALTER TABLE Orders
ADD Foreign Key (ProductID) references Products(ID)

ALTER TABLE Employee
ADD Foreign Key (Customers) references Customers(ID)

SELECT * FROM Products
SELECT * FROM Customers
SELECT * FROM Orders

INSERT Products
VALUES ('Thing1', 10.00),  ('Thing2', 20.00),  ('Thing3', 30.00)

Insert Customers 
Values ('Lance', 'Smith', 17), ('Roy', 'Anderson', 18), ('Bob', 'Small', 19)

Insert Orders
Values (1,3), (2,2), (3,1)

INSERT Products
Values ('iPhone', 200.00);

insert Customers
Values ('Tina', 'Smith', 20);

insert Orders
Values (4,4)

Select ID from Orders
Where CustomerID = 4

Select b.Price, COUNT(a.ProductID) as 'number of units sold'
FROM Orders a, Products b
Where (a.ProductID = b.ID) AND b.ID = 4
GROUP BY b.Price



Update Products
Set Price = 250.00
Where Name = 'iPhone'



