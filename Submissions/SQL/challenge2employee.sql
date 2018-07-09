CREATE DATABASE Challenge2;

CREATE TABLE Department(
	DeptID int NOT NULL,
	Name varchar(100) NOT NULL,
	Location varchar(100) NOT NULL,
	PRIMARY KEY (DeptID)
);

INSERT INTO Department(DeptID, Name, Location)
VALUES (1, 'Marketing', 'Reston, VA');

INSERT INTO Department(DeptID, Name, Location)
VALUES (2, 'Technical Support', 'Chicago, IL');

INSERT INTO Department(DeptID, Name, Location)
VALUES (3, 'Database Management', 'Indianapolis, IN');

SELECT * FROM Department;

CREATE TABLE Employee(
	ID int,
	FirstName varchar(100),
	LastName varchar(100),
	SSN int UNIQUE,
	DeptID int,
	PRIMARY KEY (ID),
	FOREIGN KEY (DeptID) REFERENCES Department(DeptID)
);

INSERT INTO Employee(ID, FirstName, LastName, SSN, DeptID)
VALUES (1, 'Tina', 'Smith', 123-45-6789, 1); -- I noticed there's a bit of a formatting issue with the SSN. Woops!

INSERT INTO Employee(ID, FirstName, LastName, SSN, DeptID)
VALUES (2, 'Wesley', 'Schull', 234-56-7890, 3);

INSERT INTO Employee(ID, FirstName, LastName, SSN, DeptID)
VALUES (3, 'Jason', 'Martin', 135-79-2468, 2);

SELECT * FROM Employee;

CREATE TABLE EmpDetails(
	ID int PRIMARY KEY,
	EmployeeID int FOREIGN KEY REFERENCES Employee(ID),
	Salary int,
	Address1 varchar(100) NOT NULL,
	Address2 varchar(100),
	City varchar(20),
	State varchar(20),
	Country varchar(20)
);

INSERT INTO EmpDetails (ID, EmployeeID, Salary, Address1, Address2, City, State, Country)
VALUES (1, 1, 50000, '100 Northwind Ln', 'Apt 105', 'Washington', 'Virginia', 'United States');

INSERT INTO EmpDetails (ID, EmployeeID, Salary, Address1, Address2, City, State, Country)
VALUES (2, 2, 45000, '300 Kilgore Ave', '', 'Chicago', 'Illinois', 'United States');

INSERT INTO EmpDetails (ID, EmployeeID, Salary, Address1, Address2, City, State, Country)
VALUES (3, 3, 60000, '425 Farmer''s St', '', 'Carmel', 'Indiana', 'United States');

SELECT * FROM EmpDetails;

SELECT * FROM Employee
WHERE DeptID = 1;

UPDATE EmpDetails
SET Salary = 90000
WHERE EmployeeID = 1;

-- Just gets Tina Smith's salary... but not all of Marketing.
SELECT SUM(Salary)
FROM EmpDetails
WHERE (EmployeeID = 3);
