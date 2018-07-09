--CREATE DATABASE Employee;
GO

CREATE SCHEMA List;
GO

CREATE TABLE List.Employee{

alter table List.Employee
add ID int;
add firstname nvarchar;
add lastname nvarchar;
add ssn int;
add deptid int;
	INSERT INTO List.Employee(firstname, lastname)
	values(Tina, Smith);
	
}

CREATE TABLE List.Department{

alter table List.Department
add ID int;
add name nvarchar;
add location nvarchar;

insert into List.Department(name)
values(marketing);

}


CREATE TABLE List.EmpDetails{

alter table List.EmpDetails
add ID int;
add	EmployeeID int;
add	Salary int;
add	Address 1 nvarchar;
add	Address 2 nvarchar;
add	City nvarchar;
add	State nvarchar;
add	Country nvarchar;


}

SELECT Marketing *
from List.Department;

select salary
from List.Emp.Details

select employees



