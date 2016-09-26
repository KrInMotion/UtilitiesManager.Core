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
INSERT INTO [dbo].[Providers] (Id, ProviderName) VALUES(9, N'Финансовое управление администрации города Тулы')
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
INSERT INTO [dbo].[Kinds] (Id, KindName) VALUES(6, N'Квитанция за стационарный телефон')
INSERT INTO [dbo].[Kinds] (Id, KindName) VALUES(7, N'Счет за интернет')
INSERT INTO [dbo].[Kinds] (Id, KindName) VALUES(8, N'Счет за телевидение')
INSERT INTO [dbo].[Kinds] (Id, KindName) VALUES(9, N'Счет за мобильную связь')
INSERT INTO [dbo].[Kinds] (Id, KindName) VALUES(10, N'Квитанция за детский сад')
GO
SET IDENTITY_INSERT [dbo].[Kinds] OFF
GO
SET IDENTITY_INSERT [dbo].[Invoices] ON
GO
INSERT INTO [dbo].[Invoices] (Id, Number, Account, KindId, ProviderId, MonthId, Year, Sum, Debt, Penalty, PaymentSum, PaymentDate, CreatedAt) 
  VALUES(1, N'1234-F56', N'71', 1, 1, 3, 2016, 164.4, 0, 0, 0, NULL, '20160830')
INSERT INTO [dbo].[Invoices] (Id, Number, Account, KindId, ProviderId, MonthId, Year, Sum, Debt, Penalty, PaymentSum, PaymentDate, Note, CreatedAt)
  VALUES(2, N'80-895-12', N'5435454343454354354534', 3, 2, 7, 2016, 2600, 10.10, 0, 0, NULL, N'Олатить до 20 числа след. месяца. Показания до 23', '20160901')
INSERT INTO [dbo].[Invoices] (Id, Number, Account, KindId, ProviderId, MonthId, Year, Sum, Debt, Penalty, PaymentSum, PaymentDate, CreatedAt) 
  VALUES(3, N'123456', N'0000000000', 1, 1, 8, 2016, 124.56, 1000, 50.8, 0, NULL, '20160901')
INSERT INTO [dbo].[Invoices] (Id, Number, Account, KindId, ProviderId, MonthId, Year, Sum, Debt, Penalty, PaymentSum, PaymentDate, CreatedAt) 
  VALUES(4, N'145', N'946546', 4, 2, 7, 2016, 56, 0, 0, 0, NULL, '20160820')
INSERT INTO [dbo].[Invoices] (Id, Number, Account, KindId, ProviderId, MonthId, Year, Sum, Debt, Penalty, PaymentSum, PaymentDate, CreatedAt) 
  VALUES(5, N'АБ567', N'71018946546', 6, 4, 5, 2016, 500.45, 0, 0, 0, NULL, '20160820')
INSERT INTO [dbo].[Invoices] (Id, Number, Account, KindId, ProviderId, MonthId, Year, Sum, Debt, Penalty, PaymentSum, PaymentDate, CreatedAt) 
  VALUES(6, N'871010219034/1608', N'871010219034', 6, 5, 8, 2016, 72.00, 0, 0, 72.00, '20160912', '20160912')
INSERT INTO [dbo].[Invoices] (Id, Number, Account, KindId, ProviderId, MonthId, Year, Sum, Debt, Penalty, PaymentSum, PaymentDate, CreatedAt) 
  VALUES(7, N'Без номера', N'99010602071', 3, 6, 8, 2016, 469.94, 0, 0, 469.94, '20160917', '20160917')
INSERT INTO [dbo].[Invoices] (Id, Number, Account, KindId, ProviderId, MonthId, Year, Sum, Debt, Penalty, PaymentSum, PaymentDate, CreatedAt) 
  VALUES(8, N'1633053', N'100048189', 2, 3, 9, 2016, 33.50, 0, 0, 0, NULL, '20160922')
INSERT INTO [dbo].[Invoices] (Id, Number, Account, KindId, ProviderId, MonthId, Year, Sum, Debt, Penalty, PaymentSum, PaymentDate, CreatedAt) 
  VALUES(9, N'23298', N'101053026', 1, 4, 9, 2016, 160.07, 0, 0, 0, NULL, '20160922')
INSERT INTO [dbo].[Invoices] (Id, Number, Account, KindId, ProviderId, MonthId, Year, Sum, Debt, Penalty, PaymentSum, PaymentDate, CreatedAt) 
  VALUES(10, N'Без номера', N'1014106328', 4, 1, 9, 2016, 2080.45, 0, 0, 0, NULL, '20160922')
INSERT INTO [dbo].[Invoices] (Id, Number, Account, KindId, ProviderId, MonthId, Year, Sum, Debt, Penalty, PaymentSum, PaymentDate, CreatedAt) 
  VALUES(11, N'Без номера', N'8604001460312265800012', 10, 9, 8, 2016, 984.76, 0, 0, 0, NULL, '20160922')
INSERT INTO [dbo].[Invoices] (Id, Number, Account, KindId, ProviderId, MonthId, Year, Sum, Debt, Penalty, PaymentSum, PaymentDate, CreatedAt) 
  VALUES(12, N'Без номера', N'7100092510652', 5, 2, 9, 2016, 155.42, 0, -0.08, 155.42, '20160926', '20160926')
GO
SET IDENTITY_INSERT [dbo].[Invoices] OFF
GO
