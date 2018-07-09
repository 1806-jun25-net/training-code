create database SQLChallenge;

--create tables
create table Employee(
	ID int primary key identity,
	FistName NVARCHAR(64) NOT NULL,
	LastName NVARCHAR(64) NOT NULL,
	SSN INT NOT NULL,
	DeptID INT NOT NULL);

create table EmpDetails(
	ID INT primary key identity,
	EmployeeID INT NOT NULL,
	Salary money NOT NULL,
	Address1 NVARCHAR(64) NOT NULL,
	Address2 NVARCHAR(64) NULL,
	City NVARCHAR(64) NOT NULL,
	State NVARCHAR(64) NOT NULL,
	Country NVARCHAR(64) NOT NULL);

create table Department(
	ID INT primary key identity,
	Name NVARCHAR(64) NOT NULL,
	Location NVARCHAR(64) NOT NULL);

--add FKs
alter table Employee
add constraint FK_EmployeeDeptID 
foreign key (DeptID) 
references Department(ID)

alter table Employee
add foreign key (DeptID) references Department(ID);

alter table EmpDetails
add constraint FK_EmployeeID_ID
foreign key (EmployeeID)
references Employee(ID)

alter table EmpDetails
add foreign key (EmployeeID) references Employee(ID);

--add 3 records to each table
insert into Department (Name, Location)
values 
('Marketing', 'Herndon'),
('Sales','Ashburn'),
('IT', 'Sterling');

insert into Employee (FirstName, LastName, SSN, DeptID)
values 
('Sally', 'May', 1234, 1),
('Mark', 'Harris', 5678, 2),
('David', 'Dubrail', 3456, 3);

insert into EmpDetails (EmployeeID, Salary, Address1, Address2, City, State, Country)
values
(1, 50000, '1265 Drury Lane', '', 'Somewhere', 'VA', 'United States'),
(2, 45000, '5676 Times Square', 'APT 206', 'New York', 'NY', 'United States'),
(3, 65000, '4678 Henessy Qt', '', 'Greensborough', 'NC', 'United States');

--add Tina Smith
insert into Employee (FirstName, LastName, SSN, DeptID)
values ('Tina', 'Smith', 6578, 1);

--list all employees in Marketing
select *
from Employee
where DeptID in 
	(select ID
	from department
	where name = 'Marketing')

--report salary of Marketing (incomplete)
select Department, sum(Salary)
from EmpDetails
group by Department

--report total employees by department
select FirstName AS concat(FirstName, ' ', LastName)
from Employee
group by DeptID

--increase salary of Tina Smith to 90k
update EmpDetails
set Salary = 90000
WHERE EmployeeID ID IN 
(substring)