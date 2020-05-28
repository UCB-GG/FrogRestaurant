using System.Collections.Generic;

using PizzaDataAccess.Contracts;
using PizzaDataAccess.Database;

namespace XUnitTestInfoTravel.Db
{
    internal class TestPizzaDbManager : IPizzaDbManager
    {
        List<PizzaPersonTable> list = new List<PizzaPersonTable>();
        public void AddNewPerson(PizzaPersonTable person)
        {
            list.Add(person);
        }
        public List<PizzaPersonTable> GetPersons()
        {
            return list;
        }
    }
}
