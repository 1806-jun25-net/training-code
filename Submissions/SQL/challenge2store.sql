CREATE TABLE Product (
  idProduct INT Identity(1,1) Primary Key NOT NULL,
  ProductName VARCHAR(255) NOT NULL,
  ProductPrice Decimal(9,2) NOT NULL);

  CREATE TABLE Customers (
  idCustomers INT NOT NULL Identity(1,1) Primary Key,
  FirstName VARCHAR(255) NULL,
  LastName VARCHAR(255) NULL,
  CardNumber INT Not Null Unique)

CREATE TABLE Orders (
  id INT NOT NULL Identity(1,1) Primary Key,
  Product_idProduct INT NOT NULL,
  Customers_idCustomers INT NOT NULL,
  INDEX fk_Customers_idx (Employee_idEmployee ASC),
  CONSTRAINT Product_idProduct
    FOREIGN KEY (Product_idProduct)
    REFERENCES Product (idProduct)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)