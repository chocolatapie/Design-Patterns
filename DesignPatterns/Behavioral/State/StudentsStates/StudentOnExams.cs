using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State.StudentsStates
{
    class StudentOnExams : IStudentState
    {
        private Student _thisStudent;

        public StudentOnExams(Student student)
        {
            _thisStudent = student;
        }

        public void PerformDailyActivity()
        {
            Console.WriteLine("Passing an exam");
            Console.WriteLine("Passing an exam");
            Console.WriteLine("Passing an exam");

        }
    }
}
