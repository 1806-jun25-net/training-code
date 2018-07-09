CREATE TABLE Department(
ID int Primary Key,
Name NVARCHAR(255),
Location NVARCHAR (255)
);

CREATE TABLE Employee(
ID int Primary key,
FirstName NVARCHAR(255),
LastName NVARCHAR(255),
SSN int CHECK (SSN<1000000000 AND SSN>99999999), --Checks that this is a 9 digit number
DeptID int,
Foreign key (DeptID) references Department(ID)
);

CREATE TABLE EmpDetails(
ID int Primary key,
EmployeeID int not null unique,
Salary int default 0,
Address1 NVARCHAR(255) default '', --default 'blank' address across all lines
Address2 NVARCHAR(255) default '',
City NVARCHAR(255) default '',
State VARCHAR(2) default '', -- Uses state code
Country NVARCHAR(255) default '',
Foreign key (EmployeeID) references Employee(ID)
);

--Added marketing
INSERT INTO Department VALUES (0, 'Marketing', 'Mason City'); --Made marketing one of the original 3, so that there would be employees in it
INSERT INTO Department VALUES (1, 'Sales', 'Des Moines');
INSERT INTO Department VALUES (2, 'Manufacturing', 'Ames');

INSERT INTO Employee VALUES (0, 'Lars','Homeboy','121212121',0);
INSERT INTO Employee VALUES (1, 'Will','Salesman','121394121',1);
INSERT INTO Employee VALUES (2, 'Lady','Cross','121212094',0);

INSERT INTO EmpDetails VALUES (0,1,60000,'123 1st Ave','','Des Moines','IA','United States');
INSERT INTO EmpDetails VALUES (1,0,45000,'1254 L St','','Mason City','IA','United States');
INSERT INTO EmpDetails VALUES (2,2,52000,'874 2nd Ave','Apt 5','Mason City','IA','United States');

Select * from EmpDetails;
--Add tina smith
INSERT INTO Employee VALUES (3, 'Tina','Smith','842212121',0);
INSERT INTO EmpDetails VALUES (3,3,39000,'99 1st St','Apt 24','Mason City','IA','United States');

--Marketing added above

-- list all employees in Marketing
SELECT * 
FROM Employee AS e,Department AS d 
Where e.DeptID = d.ID AND d.Name = 'Marketing';

-- report total salary of Marketing. 
SELECT SUM(EmpDetails.Salary) AS TotalSalary --should be 136000
FROM EmpDetails,Employee AS e,Department AS d 
WHERE EmpDetails.EmployeeID = e.ID AND e.DeptID = d.ID AND d.Name = 'Marketing';

-- report total employees by department. 
SELECT d.Name, COUNT(*) AS NumEmployee
FROM Employee AS e,Department AS d 
WHERE e.DeptID = d.ID
GROUP BY d.Name;

-- increase salary of Tina Smith to $90,000
UPDATE EmpDetails
SET Salary = 90000
WHERE EmployeeID in 
(Select id 
from Employee id 
where FirstName = 'Tina' and LastName = 'Smith');