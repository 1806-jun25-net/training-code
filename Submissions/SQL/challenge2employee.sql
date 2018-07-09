--Create the tables
CREATE TABLE Deparment (
  idDeparment INT Identity(1,1) Primary Key NOT NULL,
  DeptName VARCHAR(255) NOT NULL,
  DeptLocation VARCHAR(255) NOT NULL);

  CREATE TABLE Employee (
  idEmployee INT NOT NULL Identity(1,1) Primary Key,
  FirstName VARCHAR(255) NULL,
  LastName VARCHAR(255) NULL,
  SSN INT Not Null Unique,
  Deparment_idDeparment INT NOT NULL,
  INDEX fk_User_Deparment_idx (Deparment_idDeparment ASC),
  CONSTRAINT Deparment_idDeparment
    FOREIGN KEY (Deparment_idDeparment)
    REFERENCES Deparment (idDeparment)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)

CREATE TABLE EmployeeDetails (
  id INT NOT NULL Identity(1,1) Primary Key,
  Employee_idEmployee INT NOT NULL,
  Salary DECIMAL(9,2) NULL,  
  Address1 VARCHAR(255) NULL,
  Address2 VARCHAR(255) NULL,
  City VARCHAR(255) NULL,
  State1 VARCHAR(255) NULL,
  Country VARCHAR(255) NULL,
  INDEX fk_EmployeeID_idx (Employee_idEmployee ASC),
  CONSTRAINT Employee_idEmployee
    FOREIGN KEY (Employee_idEmployee)
    REFERENCES Employee (idEmployee)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)

-----------------------------------------------------------------------------------------------------------------------------
--Insert into Deparment Table.
	Insert into Deparment(DeptName, DeptLocation) Values('ITs','Virginia');
	Insert into Deparment(DeptName, DeptLocation) Values('Science','Florida');
	Insert into Deparment(DeptName, DeptLocation) Values('Medicine','Calorina');
	Insert into Deparment(DeptName, DeptLocation) Values('Marketing','New York');

	--Insert into Employee
	Insert into Employee(FirstName, LastName, SSN, Deparment_idDeparment) Values('Tina', 'Smith', 111001234, 4);
	Insert into Employee(FirstName, LastName, SSN, Deparment_idDeparment) Values('Randall', 'Valentin', 000123333, 4);
	Insert into Employee(FirstName, LastName, SSN, Deparment_idDeparment) Values('John', 'Wick', 1111111111, 4);
	Insert into Employee(FirstName, LastName, SSN, Deparment_idDeparment) Values('Jenny', 'Wick', 1111431111, 3);
	
	--Select every employee where the deparment is Marketing by ID.
	Select * From Employee Where Employee.Deparment_idDeparment = 4;--In here we can get all the employees on marketing. Can do inner join but i need to hurry up.
	
	--Insert into EmployeeDetails
	Insert into EmployeeDetails(Employee_idEmployee,Salary,Address1,Address2,City, State1, Country) Values(2, 2000.00, '113 Green St.', '', 'Bronze', 'New York','USA')
	Insert into EmployeeDetails(Employee_idEmployee,Salary,Address1,Address2,City, State1, Country) Values(3, 3000.00, '114 Green St.', '', 'Bronze', 'New York','USA')
	Insert into EmployeeDetails(Employee_idEmployee,Salary,Address1,Address2,City, State1, Country) Values(4, 4000.00, '115 Green St.', '', 'Bronze', 'New York','USA')
	Insert into EmployeeDetails(Employee_idEmployee,Salary,Address1,Address2,City, State1, Country) Values(4, 4000.00, '11 Yellow St.', '', 'Carrol', 'Carolina','USA')



	--Get the total of Salary
	SELECT Employee.Deparment_idDeparment, 
	COUNT(*) 
	FROM Employee 
	GROUP BY Employee.Deparment_idDeparment; 


	--Increease salary of Tina Smith
	Select * From EmployeeDetails;
	--We update Tinas salary to 9000
	UPDATE EmployeeDetails
	SET Salary = 9000
	WHERE Employee_idEmployee = 2;




