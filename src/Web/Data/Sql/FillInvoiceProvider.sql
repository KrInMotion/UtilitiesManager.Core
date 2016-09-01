USE UtilitiesDB
GO
DELETE FROM [dbo].[InvoiceProviders]
GO
SET IDENTITY_INSERT [dbo].[InvoiceProviders] ON
GO
INSERT INTO [dbo].[InvoiceProviders] (Id, InvoiceProviderName) VALUES(1, N'ООО СтройМАКС')
GO
INSERT INTO [dbo].[InvoiceProviders] (Id, InvoiceProviderName) VALUES(2, N'АО ОЕИРЦ')
GO
INSERT INTO [dbo].[InvoiceProviders] (Id, InvoiceProviderName) VALUES(3, N'ООО Мега-Т')
GO
INSERT INTO [dbo].[InvoiceProviders] (Id, InvoiceProviderName) VALUES(4, N'ООО Газпром межрегионгаз Тула')
GO
INSERT INTO [dbo].[InvoiceProviders] (Id, InvoiceProviderName) VALUES(5, N'ПАО Ростелеком')
GO
INSERT INTO [dbo].[InvoiceProviders] (Id, InvoiceProviderName) VALUES(6, N'АО «ТНС энерго Тула»')
GO
SET IDENTITY_INSERT [dbo].[InvoiceProviders] OFF
GO