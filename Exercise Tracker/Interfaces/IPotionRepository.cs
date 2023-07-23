using Exercise_Tracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Tracker.Interfaces
{
    public interface IPotionRepository
    {
        Potion SearchPotionById( int id );
        IEnumerable<Potion> GetPotions();
        void AddPotion( Potion potion );
        void UpdatePotion( Potion potion );
        void RemovePotion( int id );
    }
}
