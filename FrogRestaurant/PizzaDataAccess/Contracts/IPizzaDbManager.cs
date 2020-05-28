using System.Collections.Generic;

using PizzaDataAccess.Database;

namespace PizzaDataAccess.Contracts
{
   public interface IPizzaDbManager
    {
        List<PizzaPersonTable> GetPersons();

        void AddNewPerson(PizzaPersonTable person);
    }
}
