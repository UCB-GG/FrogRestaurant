using System.Collections.Generic;

using SoftDrinkDataAccess.Database;

namespace SoftDrinkDataAccess.Contracts
{
    public interface ISoftDrinkDbManager
    {
        List<SoftDrinkPersonTable> GetPersons();

        void AddNewPerson(SoftDrinkPersonTable person);
    }
}
