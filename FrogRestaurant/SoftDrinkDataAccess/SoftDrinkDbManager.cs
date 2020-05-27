using System.Collections.Generic;
using System.Linq;

using SoftDrinkDataAccess.Contracts;
using SoftDrinkDataAccess.Database;

namespace SoftDrinkDataAccess
{
    public class SoftDrinkDbManager : ISoftDrinkDbManager
    {
        private SoftDrinkDbContext _softDrinkDbContext;
        public SoftDrinkDbManager(SoftDrinkDbContext softDrinkDbContext)
        {
            this._softDrinkDbContext = softDrinkDbContext;
        }
        public void AddNewPerson(SoftDrinkPersonTable person)
        {
            _softDrinkDbContext.FlightPersons.Add(person);
            _softDrinkDbContext.SaveChanges();
        }

        public List<SoftDrinkPersonTable> GetPersons()
        {
            return _softDrinkDbContext.FlightPersons.ToList();
        }
    }
}
