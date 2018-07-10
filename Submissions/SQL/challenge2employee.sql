-- creating database

CREATE DATABASE EmployeeDB;

-- creating tables

CREATE TABLE Employee(
	ID INT IDENTITY,
	FirstName NVARCHAR(128),
	LastName NVARCHAR(128),
	SSN INT,
	DeptID INT
	CONSTRAINT PK_Employee PRIMARY KEY (ID)
);

CREATE TABLE EmpDetails(
	ID INT IDENTITY,
	EmployeeID INT,
	Salary INT,
	Address1 NVARCHAR(128),
	Address2 NVARCHAR(128) NULL,
	City NVARCHAR(128),
	State NVARCHAR(128),
	Country NVARCHAR(128),
	CONSTRAINT PK_EmpDetails PRIMARY KEY (ID)
);

CREATE TABLE Department(
	ID INT IDENTITY,
	Name NVARCHAR(128),
	Location NVARCHAR(128),
	CONSTRAINT PK_Department PRIMARY KEY (ID)
);

-- adding foreign keys

ALTER TABLE Employee
ADD CONSTRAINT FK_EmployeeDepartment
FOREIGN KEY (DeptID) REFERENCES Department(ID);

ALTER TABLE EmpDetails
ADD CONSTRAINT FK_DetailsEmployeeID
FOREIGN KEY (EmployeeID) REFERENCES Employee(ID);

-- adding records

INSERT INTO Department (Name, Location)
VALUES ('IT', 'Reston');

INSERT INTO Department (Name, Location)
VALUES ('Management', 'Reston');

INSERT INTO Department (Name, Location)
VALUES ('Sales', 'Reston');


INSERT INTO Employee (FirstName, LastName, SSN, DeptID)
VALUES ('John', 'Doe', 123456789, 1);

INSERT INTO Employee (FirstName, LastName, SSN, DeptID)
VALUES ('Mary', 'Sue', 123456788, 2);

INSERT INTO Employee (FirstName, LastName, SSN, DeptID)
VALUES ('Billy', 'Bob', 123456787, 3);

INSERT INTO EmpDetails (EmployeeID, Salary, Address1, City, State, Country)
VALUES (1, 60000, '123 Wallaby Way','Sterling', 'VA', 'USA');

INSERT INTO EmpDetails (EmployeeID, Salary, Address1, Address2, City, State, Country)
VALUES (4, 55000, '3200 Henry Ct', 'Apt 201', 'Reston', 'VA', 'USA');

--

INSERT INTO Employee (FirstName, LastName, SSN, DeptID)
VALUES ('Tina', 'Smith', 123456786, 2);

INSERT INTO Department (Name, Location)
VALUES ('Marketing', 'Reston');

INSERT INTO Employee (FirstName, LastName, SSN, DeptID)
VALUES ('Inne', 'Market', 123456787, 4);

INSERT INTO Employee (FirstName, LastName, SSN, DeptID)
VALUES ('Mark', 'Eting', 123456783, 4);

SELECT * FROM Employee WHERE DeptID = 4;

SELECT * FROM Employee WHERE DeptID = 
(SELECT ID FROM Department WHERE Name = 'Marketing');	

--

INSERT INTO EmpDetails (EmployeeID, Salary, Address1, City, State, Country)
VALUES (5, 50000, '324 Leaf St','Reston', 'VA', 'USA');

INSERT INTO EmpDetails (EmployeeID, Salary, Address1, City, State, Country)
VALUES (6, 50000, '81 Block Ave','Herndon', 'VA', 'USA');

--

SELECT * FROM Employee WHERE DeptID = 
(SELECT ID FROM Department WHERE Name = 'Marketing');	

--

SELECT * FROM Employee
SELECT * FROM EmpDetails
SELECT * FROM Department