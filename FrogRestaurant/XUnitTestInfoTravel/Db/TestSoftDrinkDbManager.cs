using System.Collections.Generic;

using SoftDrinkDataAccess.Contracts;
using SoftDrinkDataAccess.Database;

namespace XUnitTestInfoTravel.Db
{
    internal class TestSoftDrinkDbManager : ISoftDrinkDbManager
    {
        List<SoftDrinkPersonTable> list = new List<SoftDrinkPersonTable>();

        public void AddNewPerson(SoftDrinkPersonTable person)
        {
            list.Add(person);
        }
        public List<SoftDrinkPersonTable> GetPersons()
        {
            return list;
        }
    }
}
