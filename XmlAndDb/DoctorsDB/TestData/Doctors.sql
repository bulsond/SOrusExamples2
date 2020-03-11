USE DoctorsDB;
GO

SET IDENTITY_INSERT [dbo].[Doctors] ON;
GO

INSERT INTO [dbo].[Doctors]
	(Id, Surname, Name, Patronymic, Profession, Category)
VALUES
	(1, N'Иванова', N'Ирина', N'Петровна', N'Хирург', 1),
	(2, N'Сурова', N'Галина', N'Сергеевна', N'Терапевт', 2),
	(3, N'Молодечко', N'Наталья', N'Олеговна', N'ЛОР', 2),
	(4, N'Филипова', N'Ольга', N'Петровна', N'Физиотерапевт', 1);
GO

SET IDENTITY_INSERT [dbo].[Doctors] OFF;
GO