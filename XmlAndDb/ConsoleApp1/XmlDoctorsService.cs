using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class XmlDoctorsService
    {
        private const string _doctors = "DOCTORS";
        private const string _doctor = "DOCTOR";
        private const string _patients = "PATIENTS";
        private const string _patient = "PATIENT";
        private const string _surname = "surname";
        private const string _name = "name";
        private const string _patron = "patronymic";
        private const string _patientBirth = "date_birth";
        private const string _category = "category";
        private const string _prof = "profession";
        private const string _notes = "NOTES";
        private const string _note = "NOTE";
        private const string _noteDate = "date_note";
        private const string _noteDiagnos = "diagnos";
        private const string _notePrice = "price";

        public XmlDoctorsService()
        { }

        /// <summary>
        /// Получение коллекции докторов из файла XML
        /// </summary>
        /// <param name="file">путь к файлу</param>
        /// <returns>коллекция докторов</returns>
        public List<Doctor> GetDoctors(string file)
        {
            if (String.IsNullOrEmpty(file) || !File.Exists(file))
                throw new ArgumentException(nameof(file));

            var doctors = new List<Doctor>();
            try
            {
                var doc = XDocument.Load(file);

                foreach (XElement xdoctor in doc.Root.Elements(_doctor))
                {
                    var doctor = GetDoctorEntity(xdoctor);

                    if (xdoctor.Element(_patients) == null)
                    {
                        doctors.Add(doctor);
                        continue;
                    }

                    foreach (XElement xpatient in xdoctor.Element(_patients).Elements(_patient))
                    {
                        var patient = GetPatientEntity(xpatient);

                        if (xpatient.Element(_notes) == null)
                        {
                            doctor.Patients.Add(patient);
                            continue;
                        }

                        foreach (XElement xnote in xpatient.Element(_notes).Elements(_note))
                        {
                            Note note = GetNoteEntity(xnote);
                            patient.Notes.Add(note);
                        }

                        doctor.Patients.Add(patient);
                    }

                    doctors.Add(doctor);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return doctors;
        }

        /// <summary>
        /// Получение экземпляра Note из XElement
        /// </summary>
        /// <param name="xnote"></param>
        /// <returns></returns>
        private Note GetNoteEntity(XElement xnote)
        {
            return new Note
            {
                Date = DateTime.Parse(xnote.Element(_noteDate).Value),
                Diagnosis = xnote.Element(_noteDiagnos).Value,
                Price = decimal.Parse(xnote.Element(_notePrice).Value)
            };
        }

        /// <summary>
        /// Получение экземпляра Patient из XElement
        /// </summary>
        /// <param name="xpatient"></param>
        /// <returns></returns>
        private Patient GetPatientEntity(XElement xpatient)
        {
            return new Patient
            {
                Surname = xpatient.Element(_surname).Value,
                Name = xpatient.Element(_name).Value,
                Patronymic = xpatient.Element(_patron).Value,
                Birthdate = DateTime.Parse(xpatient.Element(_patientBirth).Value),
                Category = xpatient.Element(_category)?.Value,
            };
        }

        /// <summary>
        /// Получение экземпляра Doctor из XElement
        /// </summary>
        /// <param name="xdoctor"></param>
        /// <returns></returns>
        private Doctor GetDoctorEntity(XElement xdoctor)
        {
            return new Doctor
            {
                Surname = xdoctor.Element(_surname).Value,
                Name = xdoctor.Element(_name).Value,
                Patronymic = xdoctor.Element(_patron).Value,
                Profession = xdoctor.Element(_prof).Value,
                Category = int.Parse(xdoctor.Element(_category).Value)
            };
        }

        /// <summary>
        /// Сохранение коллекции докторов в XML файл
        /// </summary>
        /// <param name="file">путь к файлу</param>
        /// <param name="doctors">коллекция докторов</param>
        public void SaveDoctors(string file, List<Doctor> doctors)
        {
            if (String.IsNullOrEmpty(file))
                throw new ArgumentException(nameof(file));
            if (doctors == null || doctors.Count == 0)
                throw new ArgumentException(nameof(doctors));

            var xdoctors = new XElement(_doctors);
            foreach (Doctor doctor in doctors)
            {
                var d = GetDoctorXElement(doctor);
                xdoctors.Add(d);
            }

            var xdoc = new XDocument(xdoctors);
            try
            {
                xdoc.Save(file);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Получение XElement из экземпляра Doctor
        /// </summary>
        /// <param name="doctor"></param>
        /// <returns></returns>
        private XElement GetDoctorXElement(Doctor doctor)
        {
            return new XElement(_doctor,
                new XElement(_surname, doctor.Surname),
                new XElement(_name, doctor.Name),
                new XElement(_patron, doctor.Patronymic),
                new XElement(_prof, doctor.Profession),
                new XElement(_category, doctor.Category),
                GetPatientsXElement(doctor.Patients));
        }

        /// <summary>
        /// Получение XElement из коллекции Patient
        /// </summary>
        /// <param name="patients"></param>
        /// <returns></returns>
        private XElement GetPatientsXElement(List<Patient> patients)
        {
            var xpatients = new XElement(_patients);
            foreach (Patient patient in patients)
            {
                var p = GetPatientXElement(patient);
                xpatients.Add(p);
            }
            return xpatients;
        }

        /// <summary>
        /// Получение XElement из экземпляра Patient
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        private XElement GetPatientXElement(Patient patient)
        {
            return new XElement(_patient,
                new XElement(_surname, patient.Surname),
                new XElement(_name, patient.Name),
                new XElement(_patron, patient.Patronymic),
                new XElement(_patientBirth, patient.Birthdate.ToShortDateString()),
                new XElement(_category, patient.Category),
                GetNotesXElement(patient.Notes));
        }

        /// <summary>
        /// Получение XElement из коллекции Note
        /// </summary>
        /// <param name="notes"></param>
        /// <returns></returns>
        private object GetNotesXElement(List<Note> notes)
        {
            var xnotes = new XElement(_notes);
            foreach (Note note in notes)
            {
                var n = GetNoteXElement(note);
                xnotes.Add(n);
            }
            return xnotes;
        }

        /// <summary>
        /// Получение XElement из экземпляра Note
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        private XElement GetNoteXElement(Note note)
        {
            return new XElement(_note,
                new XElement(_noteDate, note.Date.ToShortDateString()),
                new XElement(_noteDiagnos, note.Diagnosis),
                new XElement(_notePrice, note.Price.ToString("N")));
        }
    }
}
