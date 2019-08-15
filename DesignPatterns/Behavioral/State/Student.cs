using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    class Student
    {
        private IStudentState _studentState;

        public Student(IStudentState studentState)
        {
            _studentState = studentState;
        }
    }
}
