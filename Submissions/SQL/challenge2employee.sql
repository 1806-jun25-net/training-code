


CREATE TABLE Department (

ID int,
Name nvarchar,
Location nvarchar,
PRIMARY KEY (ID)

);


CREATE TABLE Employee (

ID int,
FirstName nvarchar,
LastName nvarchar,
SSN int,
DeptID int,
PRIMARY KEY (ID),
FOREIGN KEY (DeptID) REFERENCES Department(ID)
);

CREATE TABLE EmpDetails(

ID int,
EmployeeID int,
Salary decimal,
Address1 nvarchar,
Address2 nvarchar,
City nvarchar,
State nvarchar,
Country nvarchar,
PRIMARY KEY (ID),
FOREIGN KEY (EmployeeID) REFERENCES Employee(ID)

);

INSERT INTO Department 
VALUES (1, 'Marketing', 'Area1'),
	(2, 'Sales', 'Area2'),
	(3, 'Something else', 'Area3');

	INSERT INTO Employee 
VALUES (1, 'Tina', 'Smith', '123456789', '1'),
	(2, 'Bob', 'Ross', '123456710', '3'),
	(3, 'Happy', 'LittleTree', '123456711', '3');

		INSERT INTO EmpDetails
VALUES (1, 1, 50000, 'Street', 'Street2', 'Colorado Springs', 'CO', 'US'),
	 (1, 2, 50000, 'Street', 'Street2', 'Colorado Springs', 'CO', 'US'),
	 (1, 3, 50000, 'Street', 'Street2', 'Colorado Springs', 'CO', 'US');



	-- list all employees in marketiing

	SELECT * FROM Employee 
	WHERE Employee.DeptID = 1;


	--list sum of marketing salary
	SELECT SUM(Salary) FROM EmpDetails
	WHERE EmpDetails.EmployeeID.DeptID = 1; 

	--report total employees by department

	SELECT COUNT(Employee)FROM Employee
	GROUP BY (DeptID);

	--increase Tina smiths salary to 90000

	UPDATE EmpDetails
	Set Salary = 90000
	WHERE EmployeeID = 1;

	


