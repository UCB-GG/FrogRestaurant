using System;
using System.Collections.Generic;
using System.Text;

using FrogRestaurant.Classes.Adaptors;
using FrogRestaurant.Classes.Factories;

using PizzaDataAccess.Contracts;

using SoftDrinkDataAccess.Contracts;

using XUnitTestInfoTravel.Db;

namespace XUnitTestInfoTravel.Factory
{
    internal class TestFactory: IFactory
    {
        ISoftDrinkDbManager _testSoftDrinkDbManager;
        IPizzaDbManager _testPizzaDbManager;

        public Adaptor GetAdaptor()
        {
            return new Adaptor();
        }

        public IPizzaDbManager GetPizzaDbManager()
        {
            if (_testPizzaDbManager == null)
            {
                _testPizzaDbManager = new TestPizzaDbManager();
            }

            return _testPizzaDbManager;
        }

        public ISoftDrinkDbManager GetSoftDrinkDbManager()
        {
            if (_testSoftDrinkDbManager == null)
            {
                _testSoftDrinkDbManager = new TestSoftDrinkDbManager();
            }

            return _testSoftDrinkDbManager;
        }
    }
}
