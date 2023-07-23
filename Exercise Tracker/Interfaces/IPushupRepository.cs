using Exercise_Tracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Tracker.Interfaces
{
    public interface IPushupRepository
    {
        Pushup SearchById( int id );

        IEnumerable<Pushup> GetAll();

        void AddRegistry( Pushup pushup );
        void RemoveRegistry( int id );

        void UpdateRegistry( Pushup pushup );
    }
}
