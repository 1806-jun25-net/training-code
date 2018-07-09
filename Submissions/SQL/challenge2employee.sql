Create Table Department(
ID Int Not Null,
Name NVarChar(20),
Location NVarChar(20),
Constraint PK_Department Primary Key (ID));

Create Table Employee(
ID Int Not Null,
FirstName NVarChar(20),
LastName NVarChar(20),
SSN NVarCHar(20),
DeptId Int Not Null,
Constraint PK_Employee Primary Key (ID),
Constraint FK_Employee Foreign Key (DeptID) References Department (ID));

Create Table EmpDetails(
ID Int Not Null,
EmployeeID Int Not Null,
Salary Float,
Address1 NVarChar(20),
Address2 NVarChar(20),
City NVarChar(20),
State NVarChar(20),
Country NVarChar(20),
Constraint PK_EmpDetails Primary Key (ID),
Constraint FK_EmpDetails Foreign Key (EmployeeID) References Employee (ID));

Insert into Department Values(1, 'Marketing', 'Revature');
Insert into Department Values(2, 'Finance', 'Revature');
Insert into Department Values(3, 'HR', 'Revature');

Insert into Employee Values(1, 'Tina', 'Smith', 123456789, 1);
Insert into Employee Values(2, 'Mark', 'Johnson', 987654321, 2);
Insert into Employee Values(3, 'Mr.', 'Robot', 7018675309, 2);

Insert into EmpDetails Values(1, 1, 50000, '522 Waffle Rd', '', 'Herndon', 'VA', 'USA');
Insert into EmpDetails Values(2, 2, 35000, '111 White Street', 'PO Box 11', 'Herndon', 'VA', 'USA');
Insert into EmpDetails Values(3, 3, 47500, 'The White House', '', 'DC', 'DC', 'USA');

Select *
From Employee Inner Join Department on Employee.DeptId = Department.ID
Where Department.Name = 'Marketing';

Select Sum(Salary) as Salar, Department.Name
From EmpDetails Inner Join Employee on EmpDetails.EmployeeID = Employee.ID
Inner Join Department on Employee.DeptId = Department.ID
Where Department.Name = 'Marketing'
Group By Department.Name;

Select Department.Name, Count(Employee.ID) as NumOfEmployees
From Department Inner Join Employee on Department.ID = Employee.DeptId
Group By Department.Name;

Update EmpDetails
Set Salary = 90000
Where ID In (
	Select ID
	From Employee
	Where FirstName = 'Tina' AND LastName = 'Smith');