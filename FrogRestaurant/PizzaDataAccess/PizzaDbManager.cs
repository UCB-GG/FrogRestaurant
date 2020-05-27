using System.Collections.Generic;
using System.Linq;

using PizzaDataAccess.Contracts;
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
            //ORACLE specific code
            //int nextValue = GetNextValue();
            //person.Id = nextValue;

            _pizzaDbContext.Persons.Add(person);

            _pizzaDbContext.SaveChanges();
        }

        public List<PizzaPersonTable> GetPersons()
        {
            return _pizzaDbContext.Persons.ToList();
        }
        //ORACLE SPECIFIC CODE
        //https://docs.oracle.com/en/database/oracle/oracle-data-access-components/19.3/odpnt/EFCoreAPI.html#GUID-770CD8EA-F963-48A5-A679-CAF471A4DB1A
        // Да се види UseOracleIdentityColumn
        //public int GetNextValue()
        //{
        //    using (var command = _pizzaDbContext.Database.GetDbConnection().CreateCommand())
        //    {
        //        command.CommandText = $"select CORE_PERSON_SEQ.NEXTVAL as NEXTVAL from dual";
        //        _pizzaDbContext.Database.OpenConnection();

        //        using (var reader = command.ExecuteReader())
        //        {
        //            reader.Read();
        //            return reader.GetInt32(0);
        //        }
        //    }
        //}
    }
}
