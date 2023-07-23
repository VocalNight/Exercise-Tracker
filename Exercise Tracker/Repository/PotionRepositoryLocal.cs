using Exercise_Tracker.Interfaces;
using Exercise_Tracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Tracker.Repository
{
    public class PotionRepositoryLocal : IPotionRepository
    {

        List<Potion> potionList = new();

        public void AddPotion( Potion potion )
        {
            potionList.Add( potion );
        }

        public IEnumerable<Potion> GetPotions()
        {
            return potionList;
        }

        public void RemovePotion( int id )
        {
            Potion potionToRemove = potionList.FirstOrDefault(p => p.Id == id)!;
            if (potionToRemove != null )
            {
                potionList.Remove(potionToRemove);
            }
        }

        public Potion SearchPotionById( int id )
        {
            return potionList.FirstOrDefault(p => p.Id == id)!;
        }

        public void UpdatePotion( Potion potion )
        {
            Potion potionToUpdate = potionList.FirstOrDefault(p => p.Id == potion.Id)!;
            if (potionToUpdate != null )
            {
                potionToUpdate.Price = potion.Price;
                potionToUpdate.StockQuantity = potion.StockQuantity;
            }
        }
    }
}
