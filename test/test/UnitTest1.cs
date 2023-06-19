using Microsoft.VisualStudio.TestTools.UnitTesting;
using stud;
using System;
using System.Collections.Generic;
using test;

namespace test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var now = DateTime.Now;
            var student = new List<stud.Student>
            {
                new Student { Grop = "Группа 1", AdmissionYear = 2020, FullName = "Евгений Куликов"},
                new Student { Grop = "Группа 1", AdmissionYear = 2020, FullName = "Ерошевский Олег"},
                new Student { Grop = "Группа 1", AdmissionYear = 2020, FullName = "Булатов Владислав"},
                new Student { Grop = "Группа 1", AdmissionYear = 2020, FullName = "Киррилов Степан"},
            };
            var marksGenerator = new MarksGenerator();
            var marks = marksGenerator.GetMarks(now, student);
            foreach (var mark in marks)
            {
                string presence = mark.IsPresent ? "Присутствовал" : "Не присутствовал";
                string reason = mark.IsPresent ? "" : (mark.AbsenceReason == AbsenceReason.Illness ? "б" : "н");

                Console.WriteLine($"Студент:{mark.Student.FullName}");
                Console.WriteLine($"Дата:{mark.Date.ToShortDateString()}");
                Console.WriteLine($"Оценка :{mark.Rating}");
                Console.WriteLine($"Присутсовал:{presence}");
                Console.WriteLine();

            }

        }
    }
}
