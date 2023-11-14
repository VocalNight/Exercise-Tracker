using Exercise_Tracker.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Tracker.Controller
{
    internal class ExcerciseController
    {
        private readonly ExcerciseService _service;

        public ExcerciseController(ExcerciseService service)
        {
            _service = service;
        }
    }
}
