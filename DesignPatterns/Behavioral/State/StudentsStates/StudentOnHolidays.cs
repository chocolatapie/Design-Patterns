using System;

namespace DesignPatterns.Behavioral.State.StudentsStates
{
    class StudentOnHolidays : IStudentState
    {
        private Student _thisStudent;

        public StudentOnHolidays(Student student)
        {
            _thisStudent = student;
        }

        public void PerformDailyActivity()
        {
            Console.WriteLine("Having fun");
        }
    }
}
