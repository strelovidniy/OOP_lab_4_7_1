using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab_4_7_1
{
    interface Input
    {
        public static void InitialisingStudent()
        {
            Console.WriteLine("Заповнiть данi про себе.");

            InitialisingStudentName();
            InitialisingStudentSurename();
            InitialisingStudentGroup();
            InitialisingStudentYear();
            InitialisingStudentAdress();
            InitialisingStudentPassport();
            InitialisingStudentAge();
            InitialisingStudentTelephone();
            InitialisingStudentRating();
        }

        private static void InitialisingStudentName()
        {
            Console.Write("Iм'я: ");

            Program.Roman.Name = Console.ReadLine();
        }

        private static void InitialisingStudentSurename()
        {
            Console.Write("Прiзвище: ");

            Program.Roman.LastName = Console.ReadLine();
        }

        private static void InitialisingStudentGroup()
        {
            Console.Write("Грпупа: ");

            Program.Roman.Group = Console.ReadLine();
        }

        private static void InitialisingStudentAdress()
        {
            Console.Write("Адреса проживання: ");

            Program.Roman.Adress = Console.ReadLine();
        }

        private static void InitialisingStudentYear()
        {
            Console.Write("Рiк вступу: ");

            Program.Roman.Year = int.Parse(Console.ReadLine());
        }

        private static void InitialisingStudentPassport()
        {
            Console.Write("Номер паспорта: ");

            Program.Roman.Passport = Console.ReadLine();
        }

        private static void InitialisingStudentAge()
        {
            Console.Write("Вiк: ");

            Program.Roman.Age = int.Parse(Console.ReadLine());
        }

        private static void InitialisingStudentTelephone()
        {
            Console.Write("Номер телефону: ");

            Program.Roman.Telephone = Console.ReadLine();
        }

        private static void InitialisingStudentRating()
        {
            Console.Write("Середнiй бал: ");

            Program.Roman.Rating = int.Parse(Console.ReadLine());
        }
    }
}
