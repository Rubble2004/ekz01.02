using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using �����;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange 
            var now = DateTime.Now;
            var students = new List<Student>
            {
                new Student { Grop = "������ 1", AdmissionYear = 2020, FullName = "������� �������"},
                new Student { Grop = "������ 1", AdmissionYear = 2020, FullName = "���������� ����"},
                new Student { Grop = "������ 1", AdmissionYear = 2020, FullName = "������� ���������"},
            
            };
            var marksGenerator = new MarksGenerator();

            //Act 
            var marks = marksGenerator.GetMarks(now, students);
            // Assert
            Assert.AreEqual(students.Count * 10, marks.Count);


        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange 
            var now = DateTime.Now;
            var students = new List<Student>
            {

                new Student { Grop = "������ 1", AdmissionYear = 2020, FullName = "������� �������"},
  
                new Student { Grop = "������ 1", AdmissionYear = 2020, FullName = "������� ���������"},
                new Student { Grop = "������ 1", AdmissionYear = 2020, FullName = "�������� ������"},
            };
            var marksGenerator = new MarksGenerator();

            //Act 
            var marks = marksGenerator.GetMarks(now, students);
            // Assert
            Assert.AreEqual(students.Count * 10, marks.Count);


        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange 
            var now = DateTime.Now;
            var students = new List<Student>
            {

                new Student { Grop = "������ 1", AdmissionYear = 2020, FullName = "������� �������"},
                new Student { Grop = "������ 1", AdmissionYear = 2020, FullName = "���������� ����"},
                new Student { Grop = "������ 1", AdmissionYear = 2020, FullName = "������� ���������"},
                new Student { Grop = "������ 1", AdmissionYear = 2020, FullName = "�������� ������"},
            };
            var marksGenerator = new MarksGenerator();

            //Act 
            var marks = marksGenerator.GetMarks(now, students);
            // Assert
            Assert.AreEqual(students.Count * 10, marks.Count);


        }

        [TestMethod]
        public void TestMethod4()
        {
            // Arrange 
            var now = DateTime.Now;
            var students = new List<Student>
            {

                new Student { Grop = "������ 1", AdmissionYear = 2020, FullName = "������� �������"},
                new Student { Grop = "������ 1", AdmissionYear = 2020, FullName = "���������� ����"},
                new Student { Grop = "������ 1", AdmissionYear = 2020, FullName = "������� ���������"},
                new Student { Grop = "������ 1", AdmissionYear = 2020, FullName = "�������� ������"},
            };
            var marksGenerator = new MarksGenerator();

            //Act 
            var marks = marksGenerator.GetMarks(now, students);
            // Assert
            Assert.AreEqual(students.Count * 10, marks.Count);


        }
    }
}
