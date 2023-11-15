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
        private readonly IExcerciseRepository<Exercise> exerciseRepository;

        public ExcerciseService(IExcerciseRepository<Exercise> exerciseRepository )
        {
            this.exerciseRepository = exerciseRepository;
        }

        public void AddExercise(Exercise exercise)
        {
            if (exercise != null)
            {
                exerciseRepository.AddRegistry(exercise);
            }
        }

    }
}
