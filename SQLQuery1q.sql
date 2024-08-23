CREATE TABLE Purchase --Orders table from vid
(
	PurchaseID int PRIMARY KEY IDENTITY (00,1), 
	CustomerID VARCHAR(MAX) NULL,
	ProductID VARCHAR(MAX) NULL,
	Category VARCHAR(MAX) NULL,
	ProductName VARCHAR(MAX) NULL,
	OriginalPrice FLOAT NULL,
	Quantity INT NULL,
	Subtotal FLOAT NULL,
	OrderDate date NULL,
)

DROP TABLE Purchase

SELECT * FROM Purchase

CREATE TABLE Customers
(
	CustomerID int PRIMARY KEY IDENTITY (74540,1), 
	CustomerName VARCHAR(MAX) NULL,
	MobileNumber NVARCHAR(MAX) NULL,
	Email VARCHAR(MAX) NULL,
)

SELECT * FROM Customers

CREATE TABLE Billing --Customers table from vid
(
	BillNo int PRIMARY KEY IDENTITY (175003800,5), 
	CustomerID VARCHAR(MAX) NULL,
	CustomerName VARCHAR(MAX) NULL,
	ProductID VARCHAR(MAX) NULL,
	ProductName VARCHAR(MAX) NULL,
	Quantity INT NULL,
	TotalPrice FLOAT NULL,
	Amount FLOAT NULL,
	Change FLOAT NULL,
	OrderDate FLOAT NULL,
)

DROP TABLE Billing

SELECT * FROM Billing