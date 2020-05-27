using System.Collections.Generic;

using PizzaDataAccess.Database;

namespace PizzaDataAccess.Contracts
{
    interface IPizzaDbManager
    {
        List<PizzaPersonTable> GetPersons();

        void AddNewPerson(PizzaPersonTable person);
    }
}
