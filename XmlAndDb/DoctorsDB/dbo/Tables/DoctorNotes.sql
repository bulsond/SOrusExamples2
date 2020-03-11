CREATE TABLE [dbo].[DoctorNotes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[DoctorId] INT NOT NULL, 
    [PatientId] INT NOT NULL, 
    [NoteId] INT NOT NULL, 
    CONSTRAINT [FK_DoctorNotes_Doctors] FOREIGN KEY ([DoctorId]) REFERENCES [Doctors]([Id]), 
    CONSTRAINT [FK_DoctorNotes_Patiens] FOREIGN KEY ([PatientId]) REFERENCES [Patients]([Id]), 
    CONSTRAINT [FK_DoctorNotes_Noties] FOREIGN KEY ([NoteId]) REFERENCES [Noties]([Id])
)
