using System;
using System.Collections.Generic;
namespace ерёмин
{
    public enum AbsenceReason
    {
        Unextcuced,
        Illness,
    }
    public class Student
    {
        public string Grop { get; set; }
        public int AdmissionYear { get; set; }
        public string FullName { get; set; }
    }
    public class Mark
    {
        public Student Student { get; set; }
        public DateTime Date { get; set; }
        public int Rating { get; set; }
        public bool IsPresent { get; set; }
        public AbsenceReason AbsenceReason { get; set; }
    }
    public class MarksGenerator
    {
        public List<Mark> GetMarks(DateTime now, List<Student> students)
        {

            var marks = new List<Mark>();
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                var currentDate = now.AddDays(i);
                foreach (var student in students)

                {
                    var mark = new Mark
                    {
                        Student = student,
                        Date = currentDate,
                        Rating = random.Next(1, 11),
                        IsPresent = random.Next(2) == 0,
                        AbsenceReason = GetRamdomAbsenceReason(random)
                    };
                    marks.Add(mark);
                }
            }
            return marks;
        }
        private AbsenceReason GetRamdomAbsenceReason(Random random)
        {
            return random.Next(2) == 0 ? AbsenceReason.Unextcuced : AbsenceReason.Illness;
        }

        
    }
}
