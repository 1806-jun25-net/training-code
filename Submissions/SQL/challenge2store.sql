CREATE DATABASE EmployeesDB;
GO

CREATE SCHEMA Employees;
GO

CREATE TABLE Employees.Department
(
	ID INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(128) NOT NULL,
	Location NVARCHAR(200)
);


CREATE TABLE Employees.Employee
(
	ID INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(128) NOT NULL,
	LastName NVARCHAR(128),
	SSN INT NOT NULL,
	DeptID INT NOT NULL
);


CREATE TABLE Employees.EmpDetails
(
	ID INT PRIMARY KEY IDENTITY,
	EmployeeID INT NOT NULL,
	Salary INT,
	Address1 NVARCHAR(200) NOT NULL,
	Address2 NVARCHAR(200),
	City NVARCHAR(128) NOT NULL,
	State NVARCHAR(200) NOT NULL,
	Country NVARCHAR(200) NOT NULL,	
);

ALTER TABLE Employees.EmpDetails
ADD CONSTRAIT FK_EmpDetails_ID FOREIGN KEY(ID) REFERENCES Employees.Employee(ID)


ALTER TABLE Employees.EmpDetails
ADD CONSTRAINT FK_EmpDetails_EmployeeID FOREIGN KEY(EmployeeID) REFERENCES Employees.Employee(ID)

ALTER TABLE Employees.Employee
ADD CONSTRAINT FK_Employee_DeptID FOREIGN KEY (DeptID) REFERENCES Employees.Department(ID);

ALTER TABLE Employees.EmpDetails
ADD CONSTRAINT FK_Employee_ID FOREIGN KEY (ID) REFERENCES Employees.Employee(ID);

INSERT INTO Employees.Department
Values('Marketing', 'Office')

INSERT INTO Employees.Department
Values('Sales', 'Office')

INSERT INTO Employees.Department
Values('IT', 'Office')

INSERT INTO Employees.Department
Values('Training', 'Office')
--SELECT * FROM Employees.Department

INSERT INTO Employees.Employee
VALUES('Tina','Smith',123456789, 1)

INSERT INTO Employees.Employee
VALUES('Bob','Dole',123651234, 2)

INSERT INTO Employees.Employee
VALUES('William','Malay',145561345, 1)

INSERT INTO Employees.Employee
VALUES('Tina','Fay',145673845, 3)

INSERT INTO Employees.Employee
VALUES('Bob','Marley',189761467, 4)

INSERT INTO Employees.EmpDetails
VALUES(50000,'123 somwhere st',null, 'Sterling','VA')

--SELECT * FROM Employees.Employee

SELECT * FROM Employees.Employee AS Employee, Employees.Department AS Department
WHERE Employee.DeptID = Department.ID AND Department.Name = 'Marketing'

