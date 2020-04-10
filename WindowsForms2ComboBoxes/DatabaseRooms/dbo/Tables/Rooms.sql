CREATE TABLE [dbo].[Rooms]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Number] INT NOT NULL, 
    [ReservationId] INT NOT NULL DEFAULT 0, 
    [RoomTypeId] INT NOT NULL, 
    CONSTRAINT [FK_Rooms_RoomTypes] FOREIGN KEY ([RoomTypeId]) REFERENCES [RoomTypes]([Id])
)
