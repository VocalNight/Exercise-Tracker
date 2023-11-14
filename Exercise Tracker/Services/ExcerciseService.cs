using Exercise_Tracker.Interfaces;
using Exercise_Tracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Tracker.Services
{
    internal class ExcerciseService
    {
        private readonly IExcerciseRepository<PushUp> pushupRepository;

        public ExcerciseService(IExcerciseRepository<PushUp> pushupRepository)
        {
            this.pushupRepository = pushupRepository;
        }

    }
}
