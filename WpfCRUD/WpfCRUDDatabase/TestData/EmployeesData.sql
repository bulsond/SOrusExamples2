-- ЗАПОЛНЕНИЕ ТЕСТОВЫМИ ДАННЫМИ ТАБЛИЦЫ Employee
USE [WpfCRUDDatabase]
GO

SET IDENTITY_INSERT [dbo].[Employees] ON;
GO

INSERT INTO [dbo].[Employees]
	(Id, LastName, FirstName, Phone)
VALUES
	(1, N'Иванова', N'Галина', N'(456)1234567'),
	(2, N'Васницова', N'Марина', N'(856)2234567'),
	(3, N'Кулагина', N'Виктория', N'(956)5634567'),
	(4, N'Молодцова', N'Ирина', N'(455)7834567'),
	(5, N'Круглов', N'Дмитрий', N'(457)9934567');
GO

SET IDENTITY_INSERT [dbo].[Employees] OFF;
GO