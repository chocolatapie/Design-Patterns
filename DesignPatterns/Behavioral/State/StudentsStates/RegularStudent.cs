﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State.StudentsStates
{
    class RegularStudent : IStudentState
    {
        private Student _thisStudent;

        public RegularStudent(Student student)
        {
            _thisStudent = student;
        }

        public void PerformDailyActivity()
        {
            Console.WriteLine("Listening classes");
            Console.WriteLine("Listening classes");
            Console.WriteLine("Listening classes");
            _thisStudent.ChangeState("Exams");
        }
    }
}
