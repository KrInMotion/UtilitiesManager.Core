USE UtilitiesDB
GO
DELETE FROM [dbo].[InvoiceTypes]
GO
SET IDENTITY_INSERT [dbo].[InvoiceTypes] ON
GO
INSERT INTO [dbo].[InvoiceTypes] (Id, InvoiceTypeName) VALUES(1, N'Квитанция за газ')
GO
INSERT INTO [dbo].[InvoiceTypes] (Id, InvoiceTypeName) VALUES(2, N'Квитанция за домофон')
GO
INSERT INTO [dbo].[InvoiceTypes] (Id, InvoiceTypeName) VALUES(3, N'Квитанция за электроэнергию')
GO
INSERT INTO [dbo].[InvoiceTypes] (Id, InvoiceTypeName) VALUES(4, N'Квитанция за коммунальные услуги')
GO
INSERT INTO [dbo].[InvoiceTypes] (Id, InvoiceTypeName) VALUES(5, N'Квитанция за кап. ремонт')
GO
INSERT INTO [dbo].[InvoiceTypes] (Id, InvoiceTypeName) VALUES(6, N'Квитанция за телефон')
GO
SET IDENTITY_INSERT [dbo].[InvoiceTypes] OFF
GO