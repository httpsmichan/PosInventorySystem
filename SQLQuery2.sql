CREATE TABLE Product
(
	
	ProductID int PRIMARY KEY IDENTITY (30140,1), 
	ProductName VARCHAR(MAX) NULL,
	Category VARCHAR(MAX) NULL,
	Price FLOAT NULL,
	Status VARCHAR(MAX) NULL,
	Date date NULL,
)

CREATE TABLE Customers
(
	CustomerID int PRIMARY KEY IDENTITY (30140,1), 
	CustomerName VARCHAR(MAX) NULL,
	MobileNumber NVARCHAR(MAX) NULL,
	Email VARCHAR(MAX) NULL,
)



CREATE TABLE Purchase
(
	PurchaseID int PRIMARY KEY IDENTITY (00,1), 
	ProductID VARCHAR(MAX) NULL,
	Category VARCHAR(MAX) NULL,
	ProductName VARCHAR(MAX) NULL,
	CustomerID VARCHAR(MAX) NULL,
	CustomerName VARCHAR(MAX) NULL,
	OriginalPrice FLOAT NULL,
	Quantity INT NULL,
	Subtotal FLOAT NULL,
	OrderDate date NULL,
)

SELECT * FROM Product

SET IDENTITY_INSERT Product ON;

