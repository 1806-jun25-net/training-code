Create Table Department(ID int Not NUll,
Name varchar(255),
Location varchar(255),
Primary Key(ID));


Create Table EmpDetails(
ID int unique Not NUll,
EmployeeID int not nUll,
Salary int not null,
Address1 varchar(255) NOT NULL,
Address2 varchar(255),
City varchar(255) not null,
State_ varchar(255) not null,
Country varchar(255) not null,
Primary Key (ID) 
);

Create Table Employee(
ID int unique not null,
FirstName varchar(255) not null,
LastName varchar(255) not null,
SSN int not null unique,
DeptID int not null,
Primary Key (ID)
);

Alter Table Employee
Add Constraint FK_Employee_DeptID Foreign Key(DeptID)
	References Department(ID)
	On Delete Cascade
	On Update cascade

Alter Table EmpDetails
Add Constraint FK_EmpDetails_EmployeeID Foreign Key(EmployeeID)
	References Employee(ID)
	On Delete Cascade
	On Update Cascade

Insert into Department(ID,Name,Location)
Values('1','Marketing','Texas')

Insert into  Employee(ID,FirstName,LastName,SSN,DeptID)
Values('1','Tina','Smith','777009339','1');

Insert into Employee(ID,FirstName,LastName,SSN,DeptID)
Values('2','Mitchell','Cranston','111220909','1');

Insert into Employee(ID, FirstName,LastName,SSN,DeptID)
Values('3','Thomas','Edison','020114040','1');

Insert Into Department(ID,Name,Location)
Values('2','Accounting','Texas');

Insert INto Department(ID,Name,Location)
Values('3','HR','Texas');

Insert into EmpDetails(ID,EmployeeID,Salary,Address1,City,State_,Country)
values('1','1','50,000','121 Tulane Dr.','Houston','US')

