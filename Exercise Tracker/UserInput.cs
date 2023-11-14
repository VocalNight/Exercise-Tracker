using Exercise_Tracker.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Tracker
{
    internal class UserInput
    {
        private readonly ExcerciseController excerciseController;

        public UserInput(ExcerciseController excerciseController )
        {
            this.excerciseController = excerciseController;
        }
    }
}
