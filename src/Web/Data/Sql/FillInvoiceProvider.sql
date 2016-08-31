USE UtilitiesDB
GO
DELETE FROM [dbo].[InvoiceProviders]
GO
SET IDENTITY_INSERT [dbo].[InvoiceProviders] ON
GO
INSERT INTO [dbo].[InvoiceProviders] (Id, InvoiceProviderName) VALUES(1, N'ПАО Газпром')
GO
INSERT INTO [dbo].[InvoiceProviders] (Id, InvoiceProviderName) VALUES(2, N'ООО ТНС Энерго')
GO
INSERT INTO [dbo].[InvoiceProviders] (Id, InvoiceProviderName) VALUES(3, N'ООО Рога и Копыта')
GO
INSERT INTO [dbo].[InvoiceProviders] (Id, InvoiceProviderName) VALUES(4, N'ПАО Роддом')
GO
INSERT INTO [dbo].[InvoiceProviders] (Id, InvoiceProviderName) VALUES(5, N'ПАО Ростелеком')
GO
INSERT INTO [dbo].[InvoiceProviders] (Id, InvoiceProviderName) VALUES(6, N'ООО Хороший дом')
GO
SET IDENTITY_INSERT [dbo].[InvoiceProviders] OFF
GO