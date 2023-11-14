using Exercise_Tracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Tracker.Interfaces
{
    public interface IExcerciseRepository<T>
    {
        PushUp SearchById( int id );

        IEnumerable<T> GetAll();

        void AddRegistry( T exercise );
        void RemoveRegistry( int id );

        void UpdateRegistry( T exercise );
    }
}
