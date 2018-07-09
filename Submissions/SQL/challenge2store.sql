


--insert 3 records on each table
INSERT INTO Products  (Name, Price)
VALUES ('Rice', 2.00);
INSERT INTO Products  (Name, Price)
VALUES ('Chicken', 9.00);
INSERT INTO Products  (Name, Price)
VALUES ('Beans', 1.00);


INSERT INTO Customers  (FirstName, LastName, CardNumber)
VALUES ('Jesica', 'Smith', '567434565');
INSERT INTO Customers  (FirstName, LastName, CardNumber)
VALUES ('Pamela', 'Martinez', '767434565');
INSERT INTO Customers  (FirstName, LastName, CardNumber)
VALUES ('Norman', 'Ravindran', '467434565');

--add product iphone

INSERT INTO Product (Name, Price)
VALUES ('Iphone', 200.00)

--add tina

INSERT INTO Customers (FirstName, LastName, Card)-- id is AI
VALUES ('Tina', 'Smith', '997434565');

--order for tina 
INSERT INTO Orders (productID, CustomerID)
VALUES (1 , 4); -- tina id would be 4


--orders by tina smith
SELECT * FROM Orders 
INNER JOIN Customer WHERE Customer.ID = Orders.CustomerID;


--increase the price of iphone 
UPDATE Productos
SET Price = 250.00
WHERE Name = 'Iphone'; 

-- revenue form iphone

SELECT
SELECT COUNT(*) FROM Orders 
INNER JOIN Products WHERE Products.ID = Orders.ID




