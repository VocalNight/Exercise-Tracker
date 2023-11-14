using Exercise_Tracker.Interfaces;
using Exercise_Tracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Tracker.Repository
{
    public class ExcerciseRepository : IExcerciseRepository<PushUp>
    {

        private readonly ExerciseTrackerContext _context;

        public ExcerciseRepository(ExerciseTrackerContext context)
        {
            _context = context;
        }

        public void AddRegistry( PushUp pushup )
        {
            _context.Add(pushup );
            _context.SaveChanges();
        }

        public IEnumerable<PushUp> GetAll()
        {
            throw new NotImplementedException();
        }

        public void RemoveRegistry( int id )
        {
            throw new NotImplementedException();
        }

        public PushUp SearchById( int id )
        {
            throw new NotImplementedException();
        }

        public void UpdateRegistry( PushUp pushup )
        {
            throw new NotImplementedException();
        }
    }
}
