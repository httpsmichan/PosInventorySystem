DROP TABLE Purchase

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

SELECT * FROM Purchase




