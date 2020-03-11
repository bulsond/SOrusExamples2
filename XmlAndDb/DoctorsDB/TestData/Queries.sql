USE DoctorsDB;
GO

SELECT 
	Id,
	Surname,
	Name,
	Patronymic,
	Profession,
	Category
FROM dbo.Doctors;

--SELECT 
--	dbo.Patients.Id,
--	dbo.Patients.Surname,
--	dbo.Patients.Name,
--	dbo.Patients.Patronymic,
--	dbo.Patients.Birthdate,
--	dbo.Patients.Category
--FROM dbo.Doctors
--INNER JOIN dbo.DoctorNotes
--	ON dbo.DoctorNotes.DoctorId = dbo.Doctors.Id
--INNER JOIN dbo.Patients
--	ON dbo.Patients.Id = dbo.DoctorNotes.PatientId
--WHERE dbo.Doctors.Id = 3;

--SELECT 
--	dbo.Noties.Date,
--	dbo.Noties.Diagnosis,
--	dbo.Noties.Price
--FROM dbo.Patients
--INNER JOIN dbo.DoctorNotes
--	ON dbo.DoctorNotes.PatientId = dbo.Patients.Id
--INNER JOIN dbo.Noties
--	ON dbo.Noties.Id = dbo.DoctorNotes.NoteId
--WHERE dbo.Patients.Id = 2;



SELECT *
FROM dbo.Patients;

SELECT *
FROM dbo.Noties;

SELECT
	dbo.Doctors.Surname,
	dbo.Doctors.Name,
	dbo.Doctors.Patronymic,
	dbo.Doctors.Profession,
	dbo.Doctors.Category,
	dbo.Patients.Surname,
	dbo.Patients.Name,
	dbo.Patients.Patronymic,
	dbo.Patients.Birthdate,
	dbo.Patients.Category,
	dbo.Noties.Date,
	dbo.Noties.Diagnosis,
	dbo.Noties.Price
FROM dbo.Doctors
LEFT JOIN dbo.DoctorNotes
	ON dbo.DoctorNotes.DoctorId = dbo.Doctors.Id
LEFT JOIN dbo.Patients
	ON dbo.Patients.Id = dbo.DoctorNotes.PatientId
LEFT JOIN dbo.Noties
	ON dbo.Noties.Id = dbo.DoctorNotes.NoteId
ORDER BY dbo.Doctors.Surname;