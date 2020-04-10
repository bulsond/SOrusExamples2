-- Тестовые данные для типов комнат
USE [RoomsDB]
GO

SET IDENTITY_INSERT [dbo].[RoomTypes] ON;
GO

INSERT INTO [dbo].[RoomTypes]
	(Id, Name, Description)
VALUES
	(1, N'Single (SGL)', N'в номере проживает один человек'),
	(2, N'Double (DBL)', N'в номере проживает два человека, одна большая кровать'),
	(3, N'Twin', N'в номере проживают два человека, две раздельные кровати'),
	(4, N'Triple (TRPL)', N'трехместное размещение (обычно две кровати + диван или раскладывающаяся кровать)'),
	(5, N'Apartment', N'номера, близкие по виду к современной квартире с местом для приготовления еды, для стирки и пр.');
GO

SET IDENTITY_INSERT [dbo].[RoomTypes] OFF;
GO
