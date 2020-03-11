USE DoctorsDB;
GO

SET IDENTITY_INSERT [dbo].[Patients] ON;
GO

INSERT INTO [dbo].[Patients]
	(Id, Surname, Name, Patronymic, Birthdate, Category)
VALUES
	(1, N'Иванов', N'Сергей', N'Петрович', '19840520', N'инвалид 1 груп.'),
	(2, N'Суров', N'Геннадий', N'Сергеевич', '19881012', null),
	(3, N'Молодечко', N'Дмитрий', N'Олегович', '19890704', null),
	(4, N'Филипов', N'Олег', N'Петрович', '19740810', N'инвалид 2 груп.');
GO

SET IDENTITY_INSERT [dbo].[Patients] OFF;
GO