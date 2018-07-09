-- Create a new Database & Schema
CREATE SCHEMA Office;
GO
CREATE DATABASE Callenge2Employee;

-- Create Tables
CREATE TABLE Office.Department 
(
    ID INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(50),
    Location NVARCHAR(50),
);

CREATE TABLE Office.Employee 
(
    ID INT PRIMARY KEY IDENTITY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    SSN NVARCHAR(9),
    DeptID INT NOT NULL
);

CREATE TABLE Office.EmpDetails 
(
    ID INT PRIMARY KEY IDENTITY,
    EmployeeID INT NOT NULL, 
    Salary    Decimal(10,2),
    Address1 NVARCHAR(50),
    Address2 NVARCHAR(50),
    City NVARCHAR(50),
    State NVARCHAR(2),
    Country NVARCHAR(50),
);

-- Add FOREIGN constraint to tables
ALTER TABLE Office.Employee 
ADD CONSTRAINT FK_Office_Department 
FOREIGN KEY (DeptID) 
REFERENCES Office.Department (ID);

ALTER TABLE Office.EmpDetails 
ADD CONSTRAINT FK_Office_EmpDetails 
FOREIGN KEY (EmployeeID) 
REFERENCES Office.Employee (ID);

-- Add record to DB
-- Insert data into Department table
INSERT INTO Office.Department VALUES
(
    'Marketing',
    'Reston'
);
INSERT INTO Office.Department VALUES
(
    'Information Technology',
    'Vienna'
);
INSERT INTO Office.Department VALUES
(
    'Accounting',
    'Herdon'
);

-- Insert data in Employee table
INSERT INTO Office.Employee VALUES
(
    'Tina',
    'Smith',
    '555112233',
     1
);
INSERT INTO Office.Employee VALUES
(
    'Alexandra',
    'Hut',
    '444112233',
     1
);
INSERT INTO Office.Employee VALUES
(
    'Chris',
    'Rodriguez',
    '789473265',
     1
);
INSERT INTO Office.Employee VALUES
(
    'Jean',
    'Semprit',
    '123456789',
    2
);
INSERT INTO Office.Employee VALUES
(
    'Noah',
    'Edison',
    '123996789',
    3
);

-- Insert data in Employee Details table
INSERT INTO Office.EmpDetails VALUES
(
    35,000.00,
    '305 Fox Lane Street',
    '',
    'Reston',
    'VA',
    'USA'
);
INSERT INTO Office.EmpDetails VALUES
(
    50,000.00,
    '1669 Lazy Lane Street',
    '',
    'Vienna',
    'VA',
    'USA'
);
INSERT INTO Office.EmpDetails VALUES
(
    50,000.00,
    '1669 Crazy Lane Street',
    '',
    'Herdon',
    'VA',
    'USA'
);

SELECT * FROM Office.Employee;
SELECT * FROM Office.EmpDetails;
SELECT * FROM Office.Department

Select FirstName, LastName FROM Office.Employee as employee
INNER JOIN Office.Department as deparment on deparment.ID = employee.DeptID; 

-- DROP DATABASE Callenge2Employee
-- DROP TABLE Employee.EmpDetails
-- DROP TABLE Employee.Employee
-- DROP TABLE Employee.Department