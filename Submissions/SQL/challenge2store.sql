create schema ProductInfo
GO

CREATE TABLE ProductInfo.Product
(
	ID int identity primary key,
	Name nvarchar(50),
	Price money
)

create table ProductInfo.Orders
(
	ID int identity primary key,
	ProductID int,
	CustomerID int
)

create table ProductInfo.Customers
(
	ID int identity primary key,
	FirstName nvarchar(50),
	LastName nvarchar(50),
	CardNumber nvarchar(20)
)

insert into Productinfo.product values('Widget', 10.00);
insert into Productinfo.product values('iPhone', 200.00);
insert into Productinfo.product values('Thingy', 50.00);

insert into productinfo.Customers values('Tina', 'Smith', '1234567890');
insert into Productinfo.customers values('Joe', 'Man', '0987654321');
insert into Productinfo.customers values('Regular', 'Guy', '5555555555');

insert into productinfo.orders values(1,2);
insert into productinfo.orders values(2,1);
insert into productinfo.orders values(3,3);

select * from productinfo.orders where CustomerID = 1;

update productinfo.Product set(price = 450) where id = 2;