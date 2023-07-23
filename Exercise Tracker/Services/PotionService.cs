using Exercise_Tracker.Interfaces;
using Exercise_Tracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Tracker.Services
{
    public class PotionService
    {
        private readonly IPotionRepository _repository;
        public PotionService(IPotionRepository repository)
        {
           _repository = repository;
        }

        public Potion GetPotion(int id)
        {
            return _repository.SearchPotionById(id);
        }

        public IEnumerable<Potion> GetPotions()
        {
            return _repository.GetPotions();
        }

        public void DeletePotion(int id)
        {
            _repository.RemovePotion(id);
        }

        public void EditPotion(int id, double price, int stockQuantity) 
        {
            Potion potionToEdit = GetPotion(id);

            if (potionToEdit != null)
            {
                potionToEdit.Price = price;
                potionToEdit.StockQuantity = stockQuantity;

                _repository.UpdatePotion(potionToEdit);
            }  
        }

        public void CreatePotion(int id, string name, int StockQuantity, double price, string description)
        {
            Potion potion = new()
            {
                Id = id,
                Name = name,
                StockQuantity = StockQuantity,
                Price = price,
                Description = description
            };

            _repository.AddPotion(potion);
        }
    }
}
