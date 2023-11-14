using Exercise_Tracker.Interfaces;
using Exercise_Tracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Tracker.Repository
{
    public class ExcerciseRepository<T> : IExcerciseRepository<T>
    {

        private readonly ExerciseTrackerContext _context;

        public ExcerciseRepository(ExerciseTrackerContext context)
        {
            _context = context;
        }

        public void AddRegistry( T exercise )
        {
            _context.Add(exercise);
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void RemoveRegistry( int id )
        {
            throw new NotImplementedException();
        }

        public T SearchById( int id )
        {
            throw new NotImplementedException();
        }

        public void UpdateRegistry( T exercise )
        {
            throw new NotImplementedException();
        }
    }
}
