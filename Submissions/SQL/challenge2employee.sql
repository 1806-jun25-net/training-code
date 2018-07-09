
Create Table Department(
	ID int Primary Key,
	[Name] varchar(30),
	[Location] varchar(30)

)
go
Create Table Employee(
	ID int Primary Key,
	FirstName varchar(30),
	LastName varchar(30),
	SSN varchar(15),
	DeptID int Foreign Key references Department(ID)
)
go
Create Table EmpDetails(
	ID int Primary Key,
	EmployeeID int Foreign Key References Employee(ID),
	Salary money,
	[Address 1] varchar(50),
	[Address 2] varchar(50),
	City varchar(30),
	[State] varchar(30),
	Country varchar(30)
)

go

insert into Department values(1, 'Sales', 'Sales Floor')

go

insert into Department values(2, 'HR', 'Corporate')

go

insert into Department values(3, 'Customer Service', 'Service Desk')

go

insert into Employee values(1, 'Kyle', 'Townsend', '111-11-1111', 1)

go

insert into Employee values(2, 'Jimmy', 'Johnson', '222-22-2222', 2)

go

insert into Employee values(3, 'Jerry', 'Ryan', '123-45-6789', 1)

go

insert into EmpDetails values(1, 3, 50000.00, '6838 Turnage Lane', null, 'Mechanicsville', 'Virginia', 'United States')

go

insert into EmpDetails values(2, 1, 45000.00, '1 Broad Street', null, 'New York', 'New York', 'United States')

go

insert into EmpDetails values(3, 2, 60000.00, '4545 Wolf Hound Drive', null, 'Mechanicsville', 'Virginia', 'United States')

go

insert into Employee values (4, 'Tina', 'Smith', '444-44-4444', 2) 

go

insert into EmpDetails values (4, 4, 60000.00, '123 Made Up Lane', null, 'Los Angeles', 'California', 'United States')

go

insert into Department Values(4, 'Marketing', 'Corporate')

go

insert into Employee Values(5, 'Tom', 'Ryan', '555-55-5555', 4)

go

Select FirstName, LastName from Employee where DeptID = 4;

go

select sum()