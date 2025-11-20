using System;
using System.Collections.Generic;

namespace HospitalManagementSystem
{
    public class HospitalDemo
    {
        public void Run()
        {
            Console.WriteLine("=== СИСТЕМА УПРАВЛІННЯ ЛІКАРНЕЮ ===\n");

            Hospital hospital = new Hospital();

            // Додавання лікарів
            hospital.AddDoctor(new Doctor(1, "Іваненко Олег", "Терапевт"));
            hospital.AddDoctor(new Doctor(2, "Петренко Марія", "Хірург"));
            hospital.AddDoctor(new Doctor(3, "Коваль Сергій", "Кардіолог"));

            // Реєстрація пацієнтів
            hospital.RegisterPatient(new Patient(1, "Коваленко Тарас", 32));
            hospital.RegisterPatient(new Patient(2, "Мельник Олена", 45));
            hospital.RegisterPatient(new Patient(3, "Бойко Андрій", 27));
            hospital.RegisterPatient(new Patient(4, "Іванчук Ірина", 51));

            // Створення палат
            hospital.CreateRoom(new HospitalRoom(101, 2));
            hospital.CreateRoom(new HospitalRoom(102, 1));
            hospital.CreateRoom(new HospitalRoom(103, 3));

            // Госпіталізація
            hospital.HospitalizePatient(1, 101);
            hospital.HospitalizePatient(2, 101);
            hospital.HospitalizePatient(3, 102);
            hospital.HospitalizePatient(4, 101); // переповнена палата

            // Медичні записи
            hospital.AddMedicalRecord(new MedicalRecord(hospital.Patients[0], hospital.Doctors[0], DateTime.Now, "Плановий огляд, призначено лікування."));
            hospital.AddMedicalRecord(new MedicalRecord(hospital.Patients[1], hospital.Doctors[1], DateTime.Now, "Операція з видалення апендикса."));
            hospital.AddMedicalRecord(new MedicalRecord(hospital.Patients[0], hospital.Doctors[2], DateTime.Now, "Кардіологічна консультація."));

            // Історія пацієнта
            Console.WriteLine("\n--- ІСТОРІЯ ПАЦІЄНТА ---");
            var history = hospital.GetPatientHistory(1);
            foreach (var record in history)
            {
                Console.WriteLine($"  Дата: {record.Date.ToShortDateString()}");
                Console.WriteLine($"  Лікар: {record.Doctor.Name}");
                Console.WriteLine($"  Опис: {record.Description}\n");
            }

            // Статистика
            Console.WriteLine(hospital.GetStatistics());
        }
    }
}
