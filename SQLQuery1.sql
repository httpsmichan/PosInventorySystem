﻿CREATE TABLE Staff
(
	StaffID int PRIMARY KEY IDENTITY (63460,1),
	Username NVARCHAR(MAX) NULL,
	Password VARCHAR(MAX) NULL,
	Email NVARCHAR(255) NULL,
	Mobilenum NVARCHAR(11) NULL,
	Role NVARCHAR(50) NULL

)

SELECT * FROM Staff

