IF NOT EXISTS (SELECT 1 FROM sys.tables Where Name = 'PClientDetail') 
BEGIN
   CREATE TABLE dbo.PClientDetail
   (
      ClientID                    INTEGER IDENTITY(1,1) CONSTRAINT PClientDetail_PK PRIMARY KEY ,
	  ClientName                  VARCHAR(45),
	  ClientAddressLine1          VARCHAR(100),
	  ClientAddressLine2          VARCHAR(100),
	  ClientState                 VARCHAR(50),
	  ClientCity                  VARCHAR(50),
	  ClientMobileNumber          VARCHAR(10),
	  ClientGSTNumber             VARCHAR(24)
   )
END

--drop table PClientDetail
--select * from PClientDetail

--INSERT INTO PClientDetail values('Vicky','TestAddr1','TestAddr2','TestState','TestCity',9552364640,'INGST-887')
--INSERT INTO PClientDetail values('Vicky1','TestAddr11','TestAddr21','TestState1','TestCity1',9552364648,'INGST-8871')