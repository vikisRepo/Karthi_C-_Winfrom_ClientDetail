IF NOT EXISTS (SELECT 1 FROM sys.tables where name = 'PCompanyDetail')
BEGIN
   CREATE TABLE dbo.PCompanyDetail
   ( 
     CompanyID                INTEGER IDENTITY(1,1) CONSTRAINT PK_PCompDet_CompanyID PRIMARY KEY,
	 Company_Name             VARCHAR(45),
	 Company_Addr1            VARCHAR(100),
	 Company_Addr2            VARCHAR(100),
	 City                     VARCHAR(45),
	 State                    VARCHAR(45),
	 GST_NO					  VARCHAR(24),
	 Contact_No				  VARCHAR(10),
	 Logo					  VARCHAR(100)
   )
END

