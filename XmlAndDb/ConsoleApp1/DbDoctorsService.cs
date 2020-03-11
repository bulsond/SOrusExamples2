using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ConsoleApp1
{
    public class DbDoctorsService
    {
        private const string conStr = @"Data Source=(localdb)\MSSQLLocalDB;" +
                "Initial Catalog=DoctorsDB;Integrated Security=True;" +
                "Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        /// <summary>
        /// Получение коллекции Докторов с Пациентами и Диагнозами
        /// </summary>
        /// <returns>коллекция Докторов</returns>
        public List<Doctor> GetDoctors()
        {
            var doctors = new List<Doctor>();

            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    List<Doctor> docs = GetDoctorsWithoutPatients(conn);
                    foreach (Doctor doctor in docs)
                    {
                        List<Patient> patients = GetPatientsByDoctorId(doctor.Id, conn);
                        if (patients.Count > 0)
                        {
                            foreach (Patient patient in patients)
                            {
                                List<Note> notes = GetNotesByPatientId(patient.Id, conn);
                                if (notes.Count > 0)
                                {
                                    patient.Notes = notes;
                                }
                            }
                            doctor.Patients = patients;
                        }

                        doctors.Add(doctor);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return doctors;
        }

        /// <summary>
        /// Получение полного списка Докторов
        /// </summary>
        /// <param name="conn"></param>
        /// <returns></returns>
        private List<Doctor> GetDoctorsWithoutPatients(SqlConnection conn)
        {
            var result = new List<Doctor>();

            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"SELECT 
	                                Id,
	                                Surname,
	                                Name,
	                                Patronymic,
	                                Profession,
	                                Category
                                    FROM dbo.Doctors;";
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var d = new Doctor
                            {
                                Id = reader.GetInt32(0),
                                Surname = reader.GetString(1),
                                Name = reader.GetString(2),
                                Patronymic = reader.GetString(3),
                                Profession = reader.GetString(4),
                                Category = Convert.ToInt32(reader.GetValue(5))
                            };
                            result.Add(d);
                        }
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Получение списка Пациентов по Id Доктора
        /// </summary>
        /// <param name="doctorId"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        private List<Patient> GetPatientsByDoctorId(int doctorId, SqlConnection conn)
        {
            var result = new List<Patient>();

            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"SELECT 
	                                    dbo.Patients.Id,
	                                    dbo.Patients.Surname,
	                                    dbo.Patients.Name,
	                                    dbo.Patients.Patronymic,
	                                    dbo.Patients.Birthdate,
	                                    dbo.Patients.Category
                                    FROM dbo.Doctors
                                    INNER JOIN dbo.DoctorNotes
	                                    ON dbo.DoctorNotes.DoctorId = dbo.Doctors.Id
                                    INNER JOIN dbo.Patients
	                                    ON dbo.Patients.Id = dbo.DoctorNotes.PatientId
                                    WHERE dbo.Doctors.Id = @id;";

                var param = new SqlParameter();
                param.ParameterName = "id";
                param.SqlDbType = System.Data.SqlDbType.Int;
                param.Value = doctorId;
                cmd.Parameters.Add(param);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var d = new Patient
                            {
                                Id = reader.GetInt32(0),
                                Surname = reader.GetString(1),
                                Name = reader.GetString(2),
                                Patronymic = reader.GetString(3),
                                Birthdate = reader.GetDateTime(4),
                                Category = Convert.ToString(reader.GetValue(5))
                            };
                            result.Add(d);
                        }
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Получение списка Диагнозов по Id Пациента
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        private List<Note> GetNotesByPatientId(int patientId, SqlConnection conn)
        {
            var result = new List<Note>();

            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"SELECT 
	                                    dbo.Noties.Date,
	                                    dbo.Noties.Diagnosis,
	                                    dbo.Noties.Price
                                    FROM dbo.Patients
                                    INNER JOIN dbo.DoctorNotes
	                                    ON dbo.DoctorNotes.PatientId = dbo.Patients.Id
                                    INNER JOIN dbo.Noties
	                                    ON dbo.Noties.Id = dbo.DoctorNotes.NoteId
                                    WHERE dbo.Patients.Id = @id;";

                var param = new SqlParameter();
                param.ParameterName = "id";
                param.SqlDbType = System.Data.SqlDbType.Int;
                param.Value = patientId;
                cmd.Parameters.Add(param);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var d = new Note
                            {
                                Date = reader.GetDateTime(0),
                                Diagnosis = reader.GetString(1),
                                Price = reader.GetDecimal(2)
                            };
                            result.Add(d);
                        }
                    }
                }
            }

            return result;
        }
    }
}
