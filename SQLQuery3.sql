﻿CREATE TABLE staff
(
	staffId int PRIMARY KEY IDENTITY (63460,1),
	username NVARCHAR(MAX) NULL,
	password VARCHAR(MAX) NULL,
	email NVARCHAR(255) NULL,
	mobilenum NVARCHAR(11) NULL

)

SELECT * FROM staff