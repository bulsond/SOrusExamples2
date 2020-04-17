USE [DatabaseDGVDisconnected]
GO

SET IDENTITY_INSERT dbo.RealEstates ON;
GO

INSERT INTO dbo.RealEstates
	(Id, City, Street, Building, Apartment)
VALUES
	(1, N'Москва', N'ул. Строителей', 23, 123),
	(2, N'Мытищи', N'ул. Ленина', 67, 12),
	(3, N'Москва', N'пр. Кутузовский', 128, 90),
	(4, N'Санкт-Петербург', N'пр. Ветеранов', 78, 12);
GO

SET IDENTITY_INSERT dbo.RealEstates OFF;
GO