-- Scaffold-DbContext -Connection "Server=tcp:escalona-1806.database.windows.net,1433;Initial Catalog=RestaurantReviewsDB;Persist Security Info=False;User ID={my_username};Password={my_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;" -Provider Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Project RestaurantReviews.Context -StartupProject RestaurantReviews.Context -Force

CREATE SCHEMA RR;
GO

CREATE TABLE RR.Restaurant
(
	ID INT IDENTITY NOT NULL,
	Name NVARCHAR(128) NOT NULL
)
GO

CREATE TABLE RR.Review
(
	ID INT IDENTITY NOT NULL,
	RestaurantID INT NOT NULL,
	ReviewerName NVARCHAR(128) NOT NULL,
	Score INT NOT NULL,
	Text NVARCHAR(2048) NOT NULL
)
GO

ALTER TABLE RR.Restaurant ADD
	CONSTRAINT PK_Restaurant_ID PRIMARY KEY (ID);
GO

ALTER TABLE RR.Review ADD
	CONSTRAINT PK_Review_ID PRIMARY KEY (ID);
GO

ALTER TABLE RR.Review ADD
	CONSTRAINT FK_Review_Restaurant
		FOREIGN KEY (RestaurantID) REFERENCES RR.Restaurant (ID);
GO
