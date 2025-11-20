using System;
using System.Collections.Generic;
using System.Linq;

namespace HospitalManagementSystem
{
    public class Hospital
    {
        public List<Doctor> Doctors { get; set; }
        public List<Patient> Patients { get; set; }
        public List<HospitalRoom> Rooms { get; set; }
        public List<MedicalRecord> Records { get; set; }

        public Hospital()
        {
            Doctors = new List<Doctor>();
            Patients = new List<Patient>();
            Rooms = new List<HospitalRoom>();
            Records = new List<MedicalRecord>();
        }

        public void AddDoctor(Doctor doctor)
        {
            Doctors.Add(doctor);
        }

        public void RegisterPatient(Patient patient)
        {
            Patients.Add(patient);
        }

        public void CreateRoom(HospitalRoom room)
        {
            Rooms.Add(room);
        }

        public void HospitalizePatient(int patientId, int roomNumber)
        {
            var patient = Patients.FirstOrDefault(p => p.Id == patientId);
            var room = Rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);

            if (patient == null || room == null)
                return;

            room.AddPatient(patient);
        }

        public void AddMedicalRecord(MedicalRecord record)
        {
            Records.Add(record);
        }

        public List<MedicalRecord> GetPatientHistory(int patientId)
        {
            return Records.Where(r => r.Patient.Id == patientId).ToList();
        }

        public string GetStatistics()
        {
            int totalDoctors = Doctors.Count;
            int totalPatients = Patients.Count;
            int totalRooms = Rooms.Count;
            int totalHospitalized = Rooms.Sum(r => r.Patients.Count);

            return
                $"СТАТИСТИКА ЛІКАРНІ:\n" +
                $"Кількість лікарів: {totalDoctors}\n" +
                $"Кількість зареєстрованих пацієнтів: {totalPatients}\n" +
                $"Кількість палат: {totalRooms}\n" +
                $"Кількість пацієнтів у палатах: {totalHospitalized}";
        }
    }
}
