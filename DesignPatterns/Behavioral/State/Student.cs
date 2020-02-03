using DesignPatterns.Behavioral.State.StudentsStates;

namespace DesignPatterns.Behavioral.State
{
    class Student
    {
        private IStudentState _studentState;

        public void SetUpInitialState(IStudentState studentState)
        {
            _studentState = studentState;
            _studentState.PerformDailyActivity();
        }

        public void ChangeState(string inputState)
        {
            switch(inputState)
            {
                case "Regular":
                    this._studentState = new RegularStudent(this);
                    this._studentState.PerformDailyActivity();
                    break;
                case "Exams":
                    this._studentState = new StudentOnExams(this);
                    this._studentState.PerformDailyActivity();
                    break;
                case "Holidays":
                    this._studentState = new StudentOnHolidays(this);
                    this._studentState.PerformDailyActivity();
                    break;
            }
        }
    }
}
