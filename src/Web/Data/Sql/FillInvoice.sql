USE UtilitiesDB
GO
DELETE FROM [dbo].[Invoices]
GO
SET IDENTITY_INSERT [dbo].[Invoices] ON
GO
INSERT INTO [dbo].[Invoices] (Id, InvoiceNum, InvoiceTypeId, InvoiceProviderId, MonthId, InvoiceYear, InvoiceSum, CreatedAt) VALUES(1, N'1234-F56', 1, 1, 3, 2016, 164.4, CAST('08/31/2016' as DateTime))
GO
INSERT INTO [dbo].[Invoices] (Id, InvoiceNum, InvoiceTypeId, InvoiceProviderId, MonthId, InvoiceYear, InvoiceSum, CreatedAt) VALUES(2, N'80-895-12', 3, 2, 7, 2016, 2600, CAST('08/10/2016' as DateTime))
GO
INSERT INTO [dbo].[Invoices] (Id, InvoiceNum, InvoiceTypeId, InvoiceProviderId, MonthId, InvoiceYear, InvoiceSum, CreatedAt) VALUES(3, N'123456', 1, 1, 8, 2016, 124.56, CAST('07/01/2016' as DateTime))
GO
INSERT INTO [dbo].[Invoices] (Id, InvoiceNum, InvoiceTypeId, InvoiceProviderId, MonthId, InvoiceYear, InvoiceSum, CreatedAt) VALUES(4, N'145', 4, 2, 7, 2016, 56, CAST('07/21/2016' as DateTime))
GO
INSERT INTO [dbo].[Invoices] (Id, InvoiceNum, InvoiceTypeId, InvoiceProviderId, MonthId, InvoiceYear, InvoiceSum, CreatedAt) VALUES(5, N'АБ567', 6, 4, 5, 2016, 500.45, CAST('08/15/2016' as DateTime))
GO
SET IDENTITY_INSERT [dbo].[Invoices] OFF
GO