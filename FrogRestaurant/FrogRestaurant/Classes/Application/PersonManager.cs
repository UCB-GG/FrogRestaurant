using System.Collections.Generic;

using FrogRestaurant.Classes.Adaptors;
using FrogRestaurant.Classes.Factories;
using FrogRestaurant.Models;

using PizzaDataAccess.Contracts;
using PizzaDataAccess.Database;

using SoftDrinkDataAccess.Contracts;
using SoftDrinkDataAccess.Database;

namespace FrogRestaurant.Classes.Application
{
    public class PersonManager
    {
        private readonly IPizzaDbManager _pizzaDbManager;
        private readonly ISoftDrinkDbManager _softDrinkDbManager;
        private Adaptor _adaptor;
        public PersonManager(IFactory factory)
        {
            this._pizzaDbManager = factory.GetPizzaDbManager();
            this._softDrinkDbManager = factory.GetSoftDrinkDbManager();

            _adaptor = factory.GetAdaptor();
        }

        public List<PersonViewModel> GetPersons()
        {
            var pizzaPersonsViewModel = _adaptor.GetPersons(_pizzaDbManager.GetPersons());
            var softDrinkPersonsViewModel = _adaptor.GetPersons(_softDrinkDbManager.GetPersons());

            pizzaPersonsViewModel.AddRange(softDrinkPersonsViewModel);

            return pizzaPersonsViewModel;
        }

        public void AddNewPerson(PersonViewModel person)
        {
            if (person.FoodItemType == 'P')
            {
                var pizzaPersonTable = new PizzaPersonTable { Name = person.PersonName };
                _pizzaDbManager.AddNewPerson(pizzaPersonTable);
            }

            if (person.FoodItemType == 'S')
            {
                var softDrinkPersonTable = new SoftDrinkPersonTable { Name = person.PersonName };
                _softDrinkDbManager.AddNewPerson(softDrinkPersonTable);
            }
        }
    }
}
