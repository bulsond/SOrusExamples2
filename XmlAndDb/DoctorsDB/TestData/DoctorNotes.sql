USE DoctorsDB;
GO

SET IDENTITY_INSERT [dbo].[DoctorNotes] ON;
GO

INSERT INTO [dbo].[DoctorNotes]
	(Id, DoctorId, PatientId, NoteId)
VALUES
	(1, 3, 4, 1),
	(2, 3, 1, 2),
	(3, 1, 2, 3),
	(4, 2, 4, 4);
GO

SET IDENTITY_INSERT [dbo].[DoctorNotes] OFF;
GO