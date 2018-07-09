

CREATE TABLE Employee
(ID int Identity(1,1), FirstName NVARCHAR(128) NOT NULL, LastName NVARCHAR(128) NOT NULL, SSN int NOT NULL, DeptID int NOT NULL);

go
CREATE TABLE Department
(ID int Identity(1,1), Name NVARCHAR(128) NOT NULL, Location NVARCHAR(128) NOT NULL);

go 
CREATE TABLE EmpDetails
(ID int Identity(1,1), EmployeeID INT, Salary decimal(13,2), Address1 NVARCHAR(128), Address2 NVARCHAR(128), City NVARCHAR(128), State NVARCHAR(128), Country NVARCHAR(128));
go

SELECT * From EmpDetails
SELECT * From Employee 
SELECT * FROM Department 

ALTER TABLE Employee
ADD Primary Key (ID)

ALTER TABLE Department
ADD Primary Key (ID)

ALTER TABLE EmpDetails
ADD Primary KEY (ID)

ALTER TABLE Employee
ADD Foreign Key (DeptID) references Department(ID)

ALTER TABLE EmpDetails
ADD Foreign KEY (EmployeeID) references Employee(ID)
go
Insert Department (Name, Location)
VALUES ('Sales', '123 Oak St.'), ('R&D', '456 Birch St.'),('Tech', '678 Maple St.')

INSERT Employee (FirstName, LastName, SSN, DeptID)
VALUES ('Lance', 'Von Ah', 123121234, 1),
('John', 'Smith', 123121235, 2),
('Paul', 'Anderson', 123121236, 3)
go
Insert EmpDetails (EmployeeID, Salary, Address1, Address2, City, State, Country)
VALUES (2, 50000.00, '123 a st.', 'apt 6', 'Carmel', 'IN', 'USA'),
(3, 60000.00, '123 b st.', 'apt 5', 'Louisville', 'KY', 'USA'),
(4, 70000.00, '123 c st.', 'apt 4', 'Lafayette', 'IN', 'USA')

Insert Department(Name, Location)
Values('Marketing', '123 Snake St.')

Insert Employee
VALUES ('Tina', 'Smith', 12315124, 4)
Insert EmpDetails
VALUES (5, 80000.00, '123 d st.', 'apt 5', 'Chicago', 'IL', 'USA')

Select FirstName, LastName From Employee
WHERE (DeptID = 4);



SELECT Sum(a.Salary) as 'Sum of Salaires', b.DeptID
From EmpDetails a, Employee b
Where (a.EmployeeID = b.ID) AND b.DeptID = 4
GROUP BY b.DeptID

SELECT Count(a.EmployeeID) as 'Number of Employees in Dept', b.DeptID
From EmpDetails a, Employee b
Where (a.EmployeeID = b.ID) 
GROUP BY b.DeptID


Update EmpDetails
Set Salary = 90000.00
Where EmployeeID = 5




