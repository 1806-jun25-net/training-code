CREATE DATABASE ChallengeStore;
GO

CREATE SCHEMA Employee;
GO

CREATE TABLE Department
(
	ID INT PRIMARY KEY,
	Name NVARCHAR(128) NOT NULL,
	Location NVARCHAR(128) NOT NULL
);

CREATE TABLE Employee
(
	ID INT PRIMARY KEY,
	FirstName NVARCHAR(128) NOT NULL,
	LastName NVARCHAR(128) NOT NULL,
	SSN INT NOT NULL,
	DeptID INT FOREIGN KEY REFERENCES Department(ID)
);

CREATE TABLE EmpDetails
(
	ID INT PRIMARY KEY,
	EmployeeID INT FOREIGN KEY REFERENCES Employee(ID),
	Salary INT NOT NULL,
	Address1 NVARCHAR(128) NOT NULL,
	Address2 NVARCHAR(128),
	City NVARCHAR(128) NOT NULL,
	State NVARCHAR(128) NOT NULL,
	Country NVARCHAR(128) NOT NULL
);

-- add at least 3 records into each table.

INSERT INTO Department
VALUES (74, 'Sports', '221B');

INSERT INTO Department
VALUES (75, 'Books', '222C');

INSERT INTO Department
VALUES (76, 'Food', '223E');

INSERT INTO Employee
VALUES (101, 'Donald', 'Trump', 123456789, 75);

INSERT INTO Employee
VALUES (102, 'Melania', 'Trump', 987654321, 76);

INSERT INTO Employee
VALUES (103, 'Eric', 'Trump', 567894321, 74);

INSERT INTO EmpDetails
VALUES (201, 101, 400000, '123 white house', '123 red house', 'DC', 'Maryland', 'US');

INSERT INTO EmpDetails
VALUES (202, 102, 200000, '456 white house', '456 red house', 'DC', 'Maryland', 'US');

INSERT INTO EmpDetails
VALUES (203, 103, 100000, '789 white house', '789 red house', 'DC', 'Maryland', 'US');


-- Add employee Tina Smith 
INSERT INTO Employee
VALUES (104, 'Tina', 'Smith', 24681357, null);

-- add department Marketing.
INSERT INTO Department
VALUES (77, 'Marketing', '224A');

-- Not required but added emp details for tina
INSERT INTO EmpDetails
VALUES (204, 104, 60000, '132 First St.', '142 Main St.', 'DC', 'Maryland', 'US');

-- list all employees in Marketing.
SELECT *
FROM Employee
WHERE Employee.DeptID = 77;

-- report total salary of Marketing.
SELECT SUM(d.Salary)
FROM EmpDetails AS d, Employee as e
WHERE d.EmployeeID = e.ID AND e.DeptID = 77;

-- report total employees by department.
SELECT COUNT(*)
FROM Employee
GROUP BY Employee.DeptID;

-- increase salary of Tina Smith to $90,000.
UPDATE EmpDetails
SET Salary = 90000
WHERE EmployeeID = 104;