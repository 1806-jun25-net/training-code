CREATE DATABASE EmployeeDB;
GO

CREATE SCHEMA Emp;
GO

DROP TABLE Emp.EmpDetails;
DROP TABLE Emp.Employee;
DROP TABLE Emp.Department;


CREATE TABLE Emp.Department
(
	ID int IDENTITY,
	Name nvarchar(20),
	Location nvarchar(20),
	PRIMARY KEY (ID)
)

CREATE TABLE Emp.Employee
(
	ID int IDENTITY,
	FirstName nvarchar(20),
	LastName nvarchar(20),
	SSN nvarchar(20),
	DeptID int,
	PRIMARY KEY (ID),
	FOREIGN KEY (DeptID) REFERENCES Emp.Department(ID)
);

CREATE TABLE Emp.EmpDetails
(
	ID int IDENTITY,
	EmployeeID int,
	Salary money,
	Address1 nvarchar(20),
	Address2 nvarchar(20),
	City nvarchar(20),
	State nvarchar(20),
	Country nvarchar(20),
	PRIMARY KEY (ID),
	FOREIGN KEY (EmployeeID) REFERENCES Emp.Employee(ID)
);

INSERT INTO Emp.Department
VALUES ('HQ', 'Reston'), ('Training', 'Texas'), ('Recruitment', 'Florida');

INSERT INTO Emp.Employee
VALUES ('Alan', 'Add', '123456789', 1), ('Bob', 'Baker', '987654321', 2), ('Charlie', 'Can', '000000000', 3);

INSERT INTO Emp.EmpDetails
VALUES (1, 1000000, 'address l11', 'addressl12', 'Reston', 'VA', 'USA'), (2, 70000, 'address l21', 'addressl22', 'Dallas', 'TX', 'USA'), (3, 10000000, 'address l31', 'addressl32', 'Tampa', 'FL', 'USA')

SELECT * FROM Emp.Department;
SELECT * FROM Emp.Employee;
SELECT * FROM Emp.EmpDetails;

--TRUNCATE TABLE Emp.Employee;
--Table now set up, on to queries ect...
INSERT INTO Emp.Employee
VALUES ('Tina', 'Smith', '999999999', 1);

INSERT INTO Emp.Department
VALUES ('Marketing', 'Australlia');

SELECT * FROM Emp.Employee WHERE DeptID = 4;

SELECT SUM(Salary) FROM Emp.EmpDetails AS a, Emp.Employee AS b WHERE a.EmployeeID = b.ID AND b.DeptID = 4 GROUP BY SALARY;

