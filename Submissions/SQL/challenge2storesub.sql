--CREATE DATABASE Store;
GO

CREATE SCHEMA List;
GO

CREATE TABLE List.Products{

alter table List.Products
add ID int;
add name nvarchar;
add price int;
	INSERT INTO List.Products(name, price)
	values(IPhone, 200);
	
}

CREATE TABLE List.Orders{

alter table List.Orders
add ID int;
add ProductID int;
add CustomerID int;

insert into List.Orders()
values();

}


CREATE TABLE List.Customers{

alter table List.Customers
add ID int;
add	firstname nvarchar; 
add	lastname nvarchar; 
add	cardnumber int; 

insert into List.Customers(firstname, lastname)
values(Tina, Smith)


}

SELECT ID From List.Customers
union
select ID from List.Orders

select firstname, lastname
from List.Customers
where 

select customerID
from List.Orders
