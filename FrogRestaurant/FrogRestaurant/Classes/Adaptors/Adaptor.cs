using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FrogRestaurant.Models;

using PizzaDataAccess.Database;

using SoftDrinkDataAccess.Database;

namespace FrogRestaurant.Classes.Adaptors
{
    public class Adaptor
    {
        public List<PersonViewModel> GetPersons(List<PizzaPersonTable> list)
        {
            return list.Select(x => new PersonViewModel { PersonName = x.Name, FoodItemDescription = "Pizza" }).ToList();
        }

        public List<PersonViewModel> GetPersons(List<SoftDrinkPersonTable> list)
        {
            return list.Select(x => new PersonViewModel { PersonName = x.Name, FoodItemDescription = "SoftDrink" }).ToList();
        }
    }
}
