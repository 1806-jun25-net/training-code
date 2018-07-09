CREATE DATABASE OrderDB;
GO

CREATE SCHEMA Ord;
GO

CREATE TABLE Ord.Products
(
	ID int IDENTITY,
	Name nvarchar(2),
	Price money,
	PRIMARY KEY(ID)
);

CREATE TABLE Ord.Customers
(
	ID int IDENTITY,
	Firstname nvarchar(20),
	Lastname nvarchar(20),
	CardNumber nvarchar(20),
	PRIMARY KEY (ID)
);

CREATE TABLE Ord.Orders
(
	ID int IDENTITY,
	ProductID int,
	CustomerID int,
	PRIMARY KEY (ID),
	FOREIGN KEY (ProductID) REFERENCES Ord.Products(ID),
	FOREIGN KEY (CustomerID) REFERENCES Ord.Customers(ID)
);

