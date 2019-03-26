using System;

namespace StudentAttendance
{
    public class Student
    {
        public string Name { get; set; }

        public int[] Scores { get; set; }

        public bool HasSixOrMore()
        {
            bool hasSixOrMore = false;
            if (Scores.Length >= 6)
            {
                hasSixOrMore = true;
            }

            return hasSixOrMore;
        }
    }
}