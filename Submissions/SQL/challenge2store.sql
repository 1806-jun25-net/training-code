create table products(
id int identity(1,1) primary key,
name nvarchar(30),
price int
);

create table customers(
id int identity(1,1) primary key,
Firstname nvarchar(30),
Lastname nvarchar(30),
CardNumber nvarchar(16)
);

create table Orders(
id int identity(1,1),
ProductsID int foreign key references products(id),
customerID int foreign key references customers(id)
);

insert into products
values('iphone', 200);

insert into customers
values('Tina', 'Smith', '1234567891234567');

insert into Orders
values(1, 1)

select * from Orders 
where customerID = 1;

