using System.Collections.Generic;
using System.Threading.Tasks;

using Common.Interfaces;
using Common.Models;

namespace FrogRestaurant.Common.Application
{
    public class PersonManager
    {
        private readonly IPizzaService _pizzaService;
        private readonly ISoftDrinkService _softDrinkService;

        public PersonManager(IServiceFactory serviceFactory)
        {
            this._pizzaService = serviceFactory.GetPizzaService();
            this._softDrinkService = serviceFactory.GetSoftDrinkService();
        }

        public async Task<List<PersonViewModel>> GetPersonsAsync()
        {
            List<PersonViewModel> allPersons = new List<PersonViewModel>();

            List<PersonViewModel> pizzaPersons = await _pizzaService.GetPersonsAsync();
            List<PersonViewModel> softDrinkPersons = await _softDrinkService.GetPersonsAsync();

            allPersons.AddRange(pizzaPersons);
            allPersons.AddRange(softDrinkPersons);

            return allPersons;
        }

        //public async Task<List<PersonViewModel>> GetPersonsAsync()
        //{
        //    var tasks = new List<Task<List<PersonViewModel>>>();

        //    List<PersonViewModel> allPersons = new List<PersonViewModel>();

        //    Task<List<PersonViewModel>> pizzaPersons = _pizzaService.GetPersonsAsync();
        //    tasks.Add(pizzaPersons);

        //    Task<List<PersonViewModel>> softDrinkPersons = _softDrinkService.GetPersonsAsync();
        //    tasks.Add(softDrinkPersons);

        //    await Task.WhenAll(tasks);

        //    allPersons.AddRange(pizzaPersons.Result);
        //    allPersons.AddRange(softDrinkPersons.Result);

        //    return allPersons;
        //}

        public void AddNewPersons(PersonViewModel person)
        {
            if (person.FoodItemDescription == "P") //Pizza
            {
                _pizzaService.AddNewPerson(person);
            }

            if (person.FoodItemDescription == "S") // SoftDrink
            {
                _softDrinkService.AddNewPerson(person);
            }
        }
    }
}
