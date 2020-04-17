IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE name = 'PUserLogin') 
BEGIN
   CREATE TABLE dbo.PUserLogin(
	   id           INTEGER IDENTITY(1,1) CONSTRAINT PK_UserLogin_ID Primary Key ,
	   userName     VARCHAR(200),
	   Password     VARCHAR(50)
   )
END
