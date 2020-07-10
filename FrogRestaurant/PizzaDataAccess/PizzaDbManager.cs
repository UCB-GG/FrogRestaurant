using System.Collections.Generic;
using System.Linq;


using PizzaDataAccess.Database;

namespace PizzaDataAccess
{
    public class PizzaDbManager : IPizzaDbManager
    {
        private PizzaDbContext _pizzaDbContext;
        public PizzaDbManager(PizzaDbContext pizzaDbContext)
        {
            this._pizzaDbContext = pizzaDbContext;
        }
        public void AddNewPerson(PizzaPersonTable person)
        {
            _pizzaDbContext.Persons.Add(person);
            _pizzaDbContext.SaveChanges();
        }

        public List<PizzaPersonTable> GetPersons()
        {
            return _pizzaDbContext.Persons.ToList();
        }
    }
}
