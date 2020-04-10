-- тестовые запросы к тб.комнаты
USE [RoomsDB]
GO

--TRUNCATE TABLE dbo.Rooms;

--SELECT [Id]
--	, [Number]
--	, [ReservationId]
--	, [RoomTypeId]
--FROM dbo.Rooms;

--SELECT [r].[Id]
--	, [r].[Number]
--	, [r].[ReservationId]
--	, [t].[Name]
--FROM dbo.Rooms AS r
--INNER JOIN dbo.RoomTypes AS t
--	ON r.RoomTypeId = t.Id
--WHERE ReservationId = 0
--ORDER BY t.Name;

SELECT [r].[Id]
	, [r].[Number]
	, [t].[Name]
FROM dbo.Rooms AS r
INNER JOIN dbo.RoomTypes AS t
	ON r.RoomTypeId = t.Id
WHERE ReservationId = 0 AND t.Id = 3
ORDER BY Number;