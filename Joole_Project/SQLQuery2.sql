SET IDENTITY_INSERT dbo.Product ON
GO
INSERT INTO dbo.Product (Product_Id, SubCategory_Id , Product_Name, Product_Image, Series, Model, Model_Year, Series_Info, Featured, UseType, Application, Mount)
VALUES ('10', '20', 'BMW', 'test', 'test', 'test', 'test', 'test', 'test', 'test', 'test', 'test')

SET IDENTITY_INSERT dbo.Product OFF;