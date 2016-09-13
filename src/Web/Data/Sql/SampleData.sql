USE UtilitiesDB
GO
DELETE FROM [dbo].[Invoices]
DELETE FROM [dbo].[Months]
DELETE FROM [dbo].[Providers]
DELETE FROM [dbo].[Kinds]
GO
SET IDENTITY_INSERT [dbo].[Months] ON
GO
INSERT INTO [dbo].[Months] (Id, MonthName) VALUES(1, N'Январь')
INSERT INTO [dbo].[Months] (Id, MonthName) VALUES(2, N'Февраль')
INSERT INTO [dbo].[Months] (Id, MonthName) VALUES(3, N'Март')
INSERT INTO [dbo].[Months] (Id, MonthName) VALUES(4, N'Апрель')
INSERT INTO [dbo].[Months] (Id, MonthName) VALUES(5, N'Май')
INSERT INTO [dbo].[Months] (Id, MonthName) VALUES(6, N'Июнь')
INSERT INTO [dbo].[Months] (Id, MonthName) VALUES(7, N'Июль')
INSERT INTO [dbo].[Months] (Id, MonthName) VALUES(8, N'Август')
INSERT INTO [dbo].[Months] (Id, MonthName) VALUES(9, N'Сентябрь')
INSERT INTO [dbo].[Months] (Id, MonthName) VALUES(10, N'Октябрь')
INSERT INTO [dbo].[Months] (Id, MonthName) VALUES(11, N'Ноябрь')
INSERT INTO [dbo].[Months] (Id, MonthName) VALUES(12, N'Декабрь')
GO
SET IDENTITY_INSERT [dbo].[Months] OFF
GO
SET IDENTITY_INSERT [dbo].[Providers] ON
GO
INSERT INTO [dbo].[Providers] (Id, ProviderName) VALUES(1, N'ООО СтройМАКС')
INSERT INTO [dbo].[Providers] (Id, ProviderName) VALUES(2, N'АО ОЕИРЦ')
INSERT INTO [dbo].[Providers] (Id, ProviderName) VALUES(3, N'ООО Мега-Т')
INSERT INTO [dbo].[Providers] (Id, ProviderName) VALUES(4, N'ООО Газпром межрегионгаз Тула')
INSERT INTO [dbo].[Providers] (Id, ProviderName) VALUES(5, N'ПАО Ростелеком')
INSERT INTO [dbo].[Providers] (Id, ProviderName) VALUES(6, N'АО «ТНС энерго Тула»')
INSERT INTO [dbo].[Providers] (Id, ProviderName) VALUES(7, N'ПАО «Вымпелком»')
INSERT INTO [dbo].[Providers] (Id, ProviderName) VALUES(8, N'ОАО «НТВ-ПЛЮС»')
GO
SET IDENTITY_INSERT [dbo].[Providers] OFF
GO
SET IDENTITY_INSERT [dbo].[Kinds] ON
GO
INSERT INTO [dbo].[Kinds] (Id, KindName) VALUES(1, N'Квитанция за газ')
INSERT INTO [dbo].[Kinds] (Id, KindName) VALUES(2, N'Квитанция за домофон')
INSERT INTO [dbo].[Kinds] (Id, KindName) VALUES(3, N'Квитанция за электроэнергию')
INSERT INTO [dbo].[Kinds] (Id, KindName) VALUES(4, N'Квитанция за коммунальные услуги')
INSERT INTO [dbo].[Kinds] (Id, KindName) VALUES(5, N'Квитанция за кап. ремонт')
INSERT INTO [dbo].[Kinds] (Id, KindName) VALUES(6, N'Квитанция за телефон')
INSERT INTO [dbo].[Kinds] (Id, KindName) VALUES(7, N'Счет за интернет')
INSERT INTO [dbo].[Kinds] (Id, KindName) VALUES(8, N'Счет за телевидение')
INSERT INTO [dbo].[Kinds] (Id, KindName) VALUES(9, N'Счет за мобильную связь')
GO
SET IDENTITY_INSERT [dbo].[Kinds] OFF
GO
SET IDENTITY_INSERT [dbo].[Invoices] ON
GO
INSERT INTO [dbo].[Invoices] (Id, Number, Account, KindId, ProviderId, MonthId, Year, Sum, Debt, Penalty, PaymentSum, PaymentDate, CreatedAt) 
  VALUES(1, N'1234-F56', N'71', 1, 1, 3, 2016, 164.4, 0, 0, 0, NULL,  CONVERT(VARCHAR, '30.08.2016', 104))
INSERT INTO [dbo].[Invoices] (Id, Number, Account, KindId, ProviderId, MonthId, Year, Sum, Debt, Penalty, PaymentSum, PaymentDate, CreatedAt)
  VALUES(2, N'80-895-12', N'5435454343454354354534', 3, 2, 7, 2016, 2600, 10.10, 0, 0, NULL, CONVERT(VARCHAR, '01.09.2016', 104))
INSERT INTO [dbo].[Invoices] (Id, Number, Account, KindId, ProviderId, MonthId, Year, Sum, Debt, Penalty, PaymentSum, PaymentDate, CreatedAt) 
  VALUES(3, N'123456', N'0000000000', 1, 1, 8, 2016, 124.56, 1000, 50.8, 0, NULL, CONVERT(VARCHAR, '01.09.2016', 104))
INSERT INTO [dbo].[Invoices] (Id, Number, Account, KindId, ProviderId, MonthId, Year, Sum, Debt, Penalty, PaymentSum, PaymentDate, CreatedAt) 
  VALUES(4, N'145', N'946546', 4, 2, 7, 2016, 56, 0, 0, 0, NULL, CONVERT(VARCHAR, '20.08.2016', 104))
INSERT INTO [dbo].[Invoices] (Id, Number, Account, KindId, ProviderId, MonthId, Year, Sum, Debt, Penalty, PaymentSum, PaymentDate, CreatedAt) 
  VALUES(5, N'АБ567', N'71018946546', 6, 4, 5, 2016, 500.45, 0, 0, 0, NULL, CONVERT(VARCHAR, '20.08.2016', 104))
INSERT INTO [dbo].[Invoices] (Id, Number, Account, KindId, ProviderId, MonthId, Year, Sum, Debt, Penalty, PaymentSum, PaymentDate, CreatedAt) 
  VALUES(6, N'871010219034/1608', N'871010219034', 6, 5, 8, 2016, 72.00, 0, 0, 72.00, CONVERT(VARCHAR, '12.09.2016', 104), CONVERT(VARCHAR, '12.09.2016', 104))
GO
SET IDENTITY_INSERT [dbo].[Invoices] OFF
GO