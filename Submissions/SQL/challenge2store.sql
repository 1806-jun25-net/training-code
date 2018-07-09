create table product (

	ID int identity primary key, 
	Name NVarchar, 
	price money

);


create table Orders (

	ID int identity primary key, 
	productID int, 
	customerID int

);


create table Customers (

	ID int identity primary key, 
	FirstName Nvarchar (250), 
	LastName NVarchar (250), 
	CardNumber NVarchar (10), 


);


alter table orders add constraint FK_Prod_Orders Foreign key (productID) REFERENCES Product(ID); 
alter table orders add constraint FK_Prod_Client Foreign key (customerID) REFERENCES Customers(ID); 

insert into product(name, price) values ('IPhone', 200); 
isert into product(name, price) values ('IPhone', 200); sert into product(name, price) values ('IPhone', 200); 
insert into Customers (FirstName, LastName, CardNumber) values ('Tina', 'Smith', '1025')
insert into Customers (FirstName, LastName, CardNumber) values ('Tina', 'Smith', '1025')
insert into Customers (FirstName, LastName, CardNumber) values ('Tina', 'Smith', '1025')

insert into Orders (productID, customerID) values (1,1)
insert into Orders (productID, customerID) values (1,2)
insert into Orders (productID, customerID) values (1,3)

select * from orders inner join Customers on Orders.customerID = Customers.ID;
select sum(price) from product where product.Name ='Iphone'; 




update product set price = 250 where  product.Name = 'Iphone';
