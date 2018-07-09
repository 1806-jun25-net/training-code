CREATE DATABASE	EmployeeInformation
GO

CREATE SCHEMA EmpInfo
GO

CREATE TABLE EmpInfo.Employee
(
	ID int IDENTITY PRIMARY KEY,
	FirstName NVARCHAR(100) NOT NULL,
	LastName NVARCHAR (100) NOT NULL,
	SSN NVARCHAR(11) NOT NULL,
	DeptID int
)

CREATE TABLE EmpInfo.Department
(
	ID int IDENTITY PRIMARY KEY,
	DeptName NVARCHAR(50),
	DeptLocation NVARCHAR(100)
)

CREATE TABLE EmpInfo.DeptIDs
(
	ID int IDENTITY PRIMARY KEY,
	DeptName NVARCHAR(50)
)

CREATE TABLE EmpInfo.EmpDetails
(
	ID int PRIMARY KEY,
	EmployeeID int NOT NULL,
	Salary MONEY,
	Address1 NVARCHAR(100),
	Address2 NVARCHAR(100),
	City NVARCHAR(50),
	HomeState NVARCHAR(2),
	Country NVARCHAR(20)
)

INSERT INTO EmpInfo.DeptIDs VALUES('Marketing');
INSERT INTO EmpInfo.DeptIDs Values('Accounting');
insert into empinfo.DeptIDs values('Sales');

insert into empinfo.Department values('Marketing', 'Room 110');
insert into empinfo.Department values('Accounting', 'Room 120');
insert into empinfo.Department values('Sales', 'Room 130');

insert into EmpInfo.Employee values('Tina', 'Smith', '001-23-4567', 1);
insert into EmpInfo.Employee values('John', 'Doe', '002-34-5678', 2);
insert into EmpInfo.Employee values('Plain', 'Jane', '009-87-6543', 3);
insert into empinfo.Employee values('Joe', 'Schmo', '000-00-001', 1);

insert into empinfo.EmpDetails values(1, 123, 200000.00, '123 Anystreet', 'Apt 201', 'Reston', 'VA', 'USA');
insert into empinfo.EmpDetails values(2, 124, 300000.00, '123 Anystreet', 'Apt 301', 'Herndon', 'VA', 'USA');
insert into empinfo.EmpDetails values(3, 321, 250000.00, '123 Anystreet', 'Apt 401', 'Dulles', 'VA', 'USA');
insert into empinfo.EmpDetails values(4, 1234, 500000.00, '123 Anystreet', 'Apt 2', 'Hattontown', 'VA', 'USA');

alter table empinfo.empdetails add deptid int
update empinfo.empdetails set deptid = 1 where id = 1;
update empinfo.empdetails set deptid = 1 where id = 4;
update empinfo.empdetails set deptid = 2 where id = 2;

select sum(salary) from empinfo.empdetails where deptid = 1;

select count(*) from empinfo.employee groupby(deptid);

update empinfo.EmpDetails set(salary = 290000.00) where id = 1;