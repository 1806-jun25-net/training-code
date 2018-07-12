

CREATE SCHEMA business;

CREATE TABLE business.Department
(
	ID INT PRIMARY KEY IDENTITY NOT NULL,
	Names VARCHAR(225),
	Locations VARCHAR(225)
);

CREATE TABLE business.Empleyee
(
	ID INT PRIMARY KEY IDENTITY NOT NULL,
	FirstName VARCHAR(225),
	LastName VARCHAR(225),
	SSN VARCHAR(225),
	DepartmentID INT

		CONSTRAINT FK_DepartIDToDeparttable FOREIGN KEY (DepartmentID)
    REFERENCES business.Department(ID)
);



CREATE TABLE business.EMPDetails
(
	ID INT PRIMARY KEY IDENTITY NOT NULL,
	EmployeeID INT,
	Salary float,
	Address1 VARCHAR(225),
	Address2 VARCHAR(225),
	City VARCHAR(225),
	States VARCHAR(225),
	Country VARCHAR(225),

			CONSTRAINT FK_EMPDetails FOREIGN KEY (EmployeeID)
    REFERENCES business.Empleyee(ID)
);
 -- ading
INSERT INTO business.Empleyee (FirstName, LastName, SSN, DepartmentID)VALUES ( 'Angel', 'Guzman', '777777777', 1)

INSERT INTO business.Empleyee (FirstName, LastName, SSN, DepartmentID)VALUES ( 'Tina', 'Something', '999999999', 1)

INSERT INTO business.Empleyee (FirstName, LastName, SSN, DepartmentID)VALUES ( 'Belito', 'LuisPescao', '999999999', 2)

INSERT INTO business.Department (Names, Locations) VALUES ( 'Social', '1 Floor')

INSERT INTO business.Department (Names, Locations) VALUES ( 'Marketing', '3 Floor')

INSERT INTO business.Department (Names, Locations) VALUES ( 'Project', '2 Floor')

INSERT INTO business.EMPDetails (Salary, Address1, Address2, City, States, Country)VALUES ( 35000, 'Some Address 1', 'Some Address 2', 'Sabana Seca', 'Toa Baja', 'Puerto Rico')

INSERT INTO business.EMPDetails (Salary, Address1, Address2, City, States, Country)VALUES ( 12000, 'Some Address 1', 'Some Address 2', 'Sabana Seca', 'Toa Baja', 'Puerto Rico')

INSERT INTO business.EMPDetails (Salary, Address1, Address2, City, States, Country)VALUES ( 45000, 'Some Address 1', 'Some Address 2', 'Sabana Seca', 'Toa Baja', 'Puerto Rico')

SELECT FirstName FROM business.Empleyee WHERE ID = ()

SELECT * FROM business.Empleyee

Select SUM()

UPDATE business.EMPDetails SET Salary = '900000' WHERE
