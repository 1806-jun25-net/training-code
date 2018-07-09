create Database Challange2 ;
go 
Create Schema Challange2;
use MOVIESDB;
create table Department (
	
	ID int identity primary key,
	Name NVarchar(250), 
	Location NVarchar (250)
);
create table Employee(
	ID int identity primary key, 
	FirstName NVarChar(250), 
	SSN NVarchar(250) Unique, 
	DeptID int 


);
create table EmpDetails(
	ID int identity primary key, 
	EmpID int, 
	Salary Money, 
	City NVarChar(250),
	Address1 NVarChar(250),
	Address2 NVarChar(250), 
	state NVarChar(250),
	country NVarChar(250)

);

alter table Employee 

Add constraint FK_Emp_Dep Foreign key (DeptID) REFERENCES Department(ID);  

alter table EmpDetails 

Add constraint FK_Emp_Details Foreign key (EmpID) REFERENCES Employee(ID); 

insert into Department(Location, Name) values ('C', 'ECorp');
insert into Department(Location, Name) values ('W', 'Umbrella'); 
insert into Department(Location, Name) values ('e', 'Skynet');

insert into Employee(FirstName, SSN, DeptID) values ('Tina Smith', '123456', 4)

insert into Employee(FirstName, SSN, DeptID) values ('John', '14756', 4)

insert into Employee(FirstName, SSN, DeptID) values ('cris', '464546', 4)

insert into EmpDetails(Address1, Address2, City, EmpID, state, Salary)values ('Reston','Here', 'Dulles', 1, 'VA', 0)
insert into EmpDetails(Address1, Address2, City, EmpID, state, Salary)values ('Reston','Not Here', 'Dulles', 2, 'VA', 0)
insert into EmpDetails(Address1, Address2, City, EmpID, state, Salary)values ('Reston','', 'Dulles', 3, 'VA', 0)

insert into Department(Location, Name) values ('e', 'Marketing');

select * from Department inner join Employee on Employee.DeptID = Department.ID where Department.Name = 'Marketing';

select Sum(EmpDetails.Salary) from Department inner join Employee on Department.ID = Employee.DeptID inner join EmpDetails on Employee.ID = EmpDetails.EmpID where Department.Name = 'Markiting';

select count(Employee.ID) from Department inner join Employee on Department.ID = Employee.DeptID inner join EmpDetails on Employee.ID = EmpDetails.EmpID Group By(Department.Name);

update EmpDetails set Salary = 90000 where EmpDetails.ID =1;

