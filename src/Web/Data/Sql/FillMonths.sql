USE UtilitiesDB
GO
DELETE FROM [dbo].[Months]
GO
SET IDENTITY_INSERT [dbo].[Months] ON
GO
INSERT INTO [dbo].[Months] (Id, MonthName) VALUES(1, N'Январь')
GO
INSERT INTO [dbo].[Months] (Id, MonthName) VALUES(2, N'Февраль')
GO
INSERT INTO [dbo].[Months] (Id, MonthName) VALUES(3, N'Март')
GO
INSERT INTO [dbo].[Months] (Id, MonthName) VALUES(4, N'Апрель')
GO
INSERT INTO [dbo].[Months] (Id, MonthName) VALUES(5, N'Май')
GO
INSERT INTO [dbo].[Months] (Id, MonthName) VALUES(6, N'Июнь')
GO
INSERT INTO [dbo].[Months] (Id, MonthName) VALUES(7, N'Июль')
GO
INSERT INTO [dbo].[Months] (Id, MonthName) VALUES(8, N'Август')
GO
INSERT INTO [dbo].[Months] (Id, MonthName) VALUES(9, N'Сентябрь')
GO
INSERT INTO [dbo].[Months] (Id, MonthName) VALUES(10, N'Октябрь')
GO
INSERT INTO [dbo].[Months] (Id, MonthName) VALUES(11, N'Ноябрь')
GO
INSERT INTO [dbo].[Months] (Id, MonthName) VALUES(12, N'Декабрь')
GO
SET IDENTITY_INSERT [dbo].[Months] OFF
GO