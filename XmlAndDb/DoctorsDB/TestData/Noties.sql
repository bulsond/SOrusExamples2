USE DoctorsDB;
GO

SET IDENTITY_INSERT [dbo].[Noties] ON;
GO

INSERT INTO [dbo].[Noties]
	(Id, Date, Diagnosis, Price)
VALUES
	(1, '20180224', N'ОРВИ', 130),
	(2, '20180113', N'ГРИПП', 100),
	(3, '20180507', N'Перелом', 250),
	(4, '20191120', N'Грипп', 100);
GO

SET IDENTITY_INSERT [dbo].[Noties] OFF;
GO