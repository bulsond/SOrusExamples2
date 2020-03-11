CREATE TABLE [dbo].[Doctors]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Surname] NVARCHAR(50) NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Patronymic] NVARCHAR(50) NOT NULL, 
    [Profession] NVARCHAR(50) NOT NULL, 
    [Category] TINYINT NULL
)
