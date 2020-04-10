-- Тестовые данные для комнат
USE [RoomsDB]
GO

SET IDENTITY_INSERT [dbo].[Rooms] ON;
GO

INSERT INTO [dbo].[Rooms]
	(Id, Number, ReservationId, RoomTypeId)
VALUES
	(1, 120, 0, 1),
	(2, 121, 1010, 3),
	(3, 122, 0, 4),
	(4, 220, 0, 2),
	(5, 221, 0, 2),
	(6, 222, 0, 3),
	(7, 400, 100, 5),
	(8, 223, 0, 3),
	(9, 224, 0, 2),
	(10, 225, 0, 4),
	(11, 320, 0, 3),
	(12, 333, 0, 4);
GO

SET IDENTITY_INSERT [dbo].[Rooms] OFF;
GO