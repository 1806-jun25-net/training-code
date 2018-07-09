CREATE DATABASE CompanyDB;

GO
CREATE SCHEMA Employees;
 
 GO
CREATE TABLE Employees.Employee
(
	ID INT PRIMARY KEY IDENTITY NOT NULL,
	FirstName VARCHAR(60) NOT NULL,
	LastName VARCHAR(60) NOT NULL,
	SSN INT UNIQUE NOT NULL,
	DeptID INT 
);

CREATE TABLE Employees.EmpDetails
(
	

);



-- 3 recors into each table
INSERT INTO Employees.Employee (FirstName, LastName,SSN)-- id is AI
VALUES ('Jesica', 'Smith', '567434565');
INSERT INTO Employees.Employee (FirstName, LastName,SSN)-- id is AI
VALUES ('Pamela', 'Martinez', '767434565');
INSERT INTO Employees.Employee (FirstName, LastName,SSN)-- id is AI
VALUES ('Norman', 'Ravindran', '467434565');

INSERT INTO Employees.EmpDetails (Salary,Adress1, Adress2, City, State, Country)-- id is AI
VALUES ('120,000', 'street 20', 'Ast. Cir', 'Reston', 'VA', 'US');
INSERT INTO Employees.EmpDetails (Salary,Adress1, Adress2, City, State, Country)-- id is AI
VALUES ('175,000', 'street 30', 'Ast. Cir', 'Herndon', 'VA', 'US');
INSERT INTO Employees.EmpDetails (Salary,Adress1, Adress2, City, State, Country)-- id is AI
VALUES ('160,000', 'street 50', 'Ast. Cir', 'Reston', 'VA', 'US');


INSERT INTO Employees.Department (Name, Location)-- id is AI
VALUES('Dept #1','Reston, VA');
INSERT INTO Employees.Department (Name, Location)-- id is AI
VALUES('Dept #2','Herndon, VA');
INSERT INTO Employees.Department (Name, Location)-- id is AI
VALUES('Dept #3','Astoria, VA');



--add Tina Smith
INSERT INTO Employees.Employee (FirstName, LastName,SSN)-- id is AI
VALUES ('Tina', 'Smith', '997434565');
INSERT INTO Employees.EmpDetails (Salary,Adress1, Adress2, City, State, Country)-- id is AI
VALUES ('175,000', 'street 30', 'Ast. Cir', 'Herndon', 'VA', 'US');

-- addd marketing dept
INSERT INTO Employees.Department (Name, Location)-- id is AI
VALUES('Marketing ','Reston, VA');

-- all employees in marketing
SELECT  FirstName, LastName 
FROM Employees.Employee 
WHERE ID IN (SELECT ID FROM Department WHERE Name = 'Marketing');

--total salary in marketing
SELECT  Salary  
FROM Employees.EmpDetails 
INNER JOIN  Employees.Employee ON Employees.Departaments.ID = Employees.Employee.DeptID
 
 
--employee by department

--increase salary of tina

UPDATE Employees.EmpDetails
SET Salary = 90,000
WHERE FirstName = 'Tina' AND LastName = 'Smith';





