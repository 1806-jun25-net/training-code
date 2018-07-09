create table Department(
	ID int identity(1,1) primary key,
	Name nvarchar(30) not null,
	Location nvarchar(30) not null
);

create table Employee(
	ID int identity(1,1) PRIMARY KEY,
	FirstName nvarchar(30),
	LastName nvarchar(30),
	SSN nvarchar(11),
	DeptID int Foreign key references Department(ID)
);

create table EmpDetails(
	ID int identity(1,1) Primary key,
	EmployeeID int foreign key references Employee(ID),
	Salary int,
	Address1 nvarchar(30),
	Address2 nvarchar(30),
	City nvarchar(30),
	State nvarchar(2),
	Country nvarchar(30)
);
-- department inserts
-- add department of Marketing
insert into Department
values('Marketing', 'Floor 2');
insert into Department
values('Accounting', 'Floor 3');
insert into Department
values('Engineering', 'Floor 4');
-- employee inserts
-- add Tina Smith
insert into Employee
values('Tina', 'Smith', '111-22-3333', 1);
insert into Employee
values('Rolando', 'Toledo', '444-55-6666', 2);
insert into Employee
values('Vilma', 'Del Valle', '777-88-9999', 1);
-- EmpDetais inserts
insert into EmpDetails
values(1, 60000, 'Somewhere I do not know', '', 'Reston', 'VA', 'USA');
insert into EmpDetails
values(2, 70000, 'Venus Tower', '', 'Trujillo', 'PR', 'USA');
insert into EmpDetails
values(3, 80000, 'Address', 'Address2', 'San Juan', 'PR', 'USA');

select * from Department;
select * from Employee;
select * from EmpDetails;

--list all emp from marketing
select * from Employee
where DeptID = 1;
-- report total salary of marketing
select sum(salary) from EmpDetails
where EmployeeID in (Select ID from Employee
where DeptID = 1);
-- report total emp by department
select count(ID) from Employee
group by DeptID;
--increase salary of tina to 90000
update EmpDetails
set Salary =  90000
where EmployeeID =1;



