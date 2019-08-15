using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }
    }
}
