CREATE TABLE Employee (
	ID int NOT NULL,
    FirstName varchar(50),
    LastName varchar(50),
    SSN int,
	FOREIGN KEY (ID) REFERENCES Department(ID),
	PRIMARY KEY (ID));

CREATE TABLE Department (
    ID int NOT NULL,
	PRIMARY KEY (ID),
	Name varchar(50),
	Location varchar(50));

CREATE TABLE EmpDetails (
    ID int NOT NULL,
	PRIMARY KEY (ID),
	FOREIGN KEY (ID) REFERENCES Employee(ID),
	Salary int,
	Address1 varchar(50),
	Address2 varchar(50),
	City varchar(10),
	State varchar(3),
	Country varchar(20));

INSERT INTO Department (Name, Location)
VALUES ('Engineering', 'Reston')

INSERT INTO Department (Name, Location) 
VALUES ('Marketing', 'Reston')

INSERT INTO Department (Name, Location) 
VALUES ('Research', 'Reston')

INSERT INTO EmpDetails (Salary, Address1, Address2, City, State, Country)
VALUES ('20000', 'Some.St', NULL, 'Reston', 'VA', 'USA')

INSERT INTO EmpDetails (Salary, Address1, Address2, City, State, Country)
VALUES ('50000', 'Other.St', NULL, 'Reston', 'VA', 'USA')

INSERT INTO EmpDetails (Salary, Address1, Address2, City, State, Country)
VALUES ('30000', 'Street.St', NULL, 'Reston', 'VA', 'USA')

INSERT INTO Employee (FirstName, LastName, SSN)
VALUES ('Jay', 'Slew', '100300000');

INSERT INTO Employee (FirstName, LastName, SSN)
VALUES ('Lay', 'Lae', '100002000');

INSERT INTO Employee (FirstName, LastName, SSN)
VALUES ('Tony', 'Danza', '100000000');

INSERT INTO Employee (FirstName, LastName, SSN)
VALUES ('Tina', 'Smith', '123000000');

SELECT SUM(Salary) from EmpDetails, Department
WHERE Department.Name = 'Marketing';

SELECT COUNT(Employee.ID), Department.Name from Employee, Department

