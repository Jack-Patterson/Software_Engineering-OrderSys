drop table OrderItems;
drop table Orders;
drop table Products;
drop table Suppliers;

-- Create Suppliers

CREATE TABLE Suppliers (
  SuppID NUMERIC(4),
  Name VARCHAR2(30) NOT NULL UNIQUE,
  Address_Street VARCHAR2(20) NOT NULL,
  Address_Town VARCHAR2(20) NOT NULL,
  Address_County VARCHAR2(20) NOT NULL,
  Address_Eir VARCHAR2(7),
  Email VARCHAR2(30) NOT NULL UNIQUE,
  PhoneNo VARCHAR2(13) NOT NULL,
  Contact VARCHAR2(30),
  CONSTRAINT pk_suppliers PRIMARY KEY(SuppID));

-- Create Products

CREATE TABLE Products (
  ProdID NUMERIC(4),
  Name VARCHAR2(20) NOT NULL,
  Price NUMERIC(6,2) NOT NULL,
  Qty NUMERIC(3) NOT NULL,
  SuppID NUMERIC(4) NOT NULL,
  Status CHAR(1),
  CONSTRAINT pk_products PRIMARY KEY(ProdID),
  CONSTRAINT fk_prod_suppliers FOREIGN KEY(SuppID) REFERENCES Suppliers(SuppID));
  
-- Create Orders 

CREATE TABLE Orders(
  OrderID NUMERIC(4),
  OrderDate DATE,
  OrderValue NUMERIC(6,2),
  SuppID NUMERIC(4) NOT NULL,
  PaidInv CHAR(1),
  CONSTRAINT pk_orders PRIMARY KEY(OrderID),
  CONSTRAINT fk_ord_suppliers FOREIGN KEY(SuppID) REFERENCES Suppliers(SuppID));
  
CREATE TABLE OrderItems(
  OrderID NUMERIC(4),
  ProdID NUMERIC(4),
  Quantity NUMERIC(3),
  Price NUMERIC(6,2),
  CONSTRAINT pk_orderitems PRIMARY KEY(OrderID, ProdID), 
  CONSTRAINT fk_orders FOREIGN KEY(OrderID) REFERENCES Orders(OrderID),
  CONSTRAINT fk_products FOREIGN KEY(ProdID) REFERENCES Products(ProdID));

-- Dummy/Test Data

DELETE FROM Suppliers;
INSERT INTO Suppliers VALUES(1, 'HP', 'Causeway', 'Tralee', 'Kerry', '12345','Joe@hp.com', '0865431234', 'Joe');
INSERT INTO Suppliers VALUES(2,'BROTHER', 'Main Street', 'Limerick', 'Limerick', '45678','tom@brother.ie', '0865433454', 'tom');
INSERT INTO Suppliers VALUES(3,'BRANSON', 'Dublin 5', 'Dublin', 'Dublin', '98765','john@gmail.co', '0845631234', 'John');
INSERT INTO Suppliers VALUES(4,'Epson', 'Cobh', 'Cork', 'Cork', '34567','Epson@epson.co.uk', '0865678906', 'N/A');

DELETE FROM Products;
INSERT INTO Products VALUES(1, 'Ink 5000', 50, 100, 1, 'A');
INSERT INTO Products VALUES(2, 'Ink 2017', 340, 20, 1, 'A');
INSERT INTO Products VALUES(3, 'Jet20', 23, 40, 2, 'A');
INSERT INTO Products VALUES(4, '4027B', 70, 203, 2, 'A');
INSERT INTO Products VALUES(5, 'Bran Son 34', 23, 54, 3, 'A');
INSERT INTO Products VALUES(6, 'Bran 3', 50, 176, 3, 'A');
INSERT INTO Products VALUES(7, 'E2021', 50, 45, 4, 'A');
INSERT INTO Products VALUES(8, 'E2020', 34, 355, 4, 'A');

INSERT INTO Orders VALUES(1, TO_DATE('2021-10-24','YYYY-MM-DD'), 344, 1, 'N');


COMMIT;