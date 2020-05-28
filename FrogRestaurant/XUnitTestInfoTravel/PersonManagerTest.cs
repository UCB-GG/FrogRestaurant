using FrogRestaurant.Classes.Application;
using FrogRestaurant.Models;

using Xunit;

using XUnitTestInfoTravel.Factory;

namespace XUnitTestInfoTravel
{
    public class PersonManagerTest
    {

        // TestMethod_Scenario_ExpectedBehavior

        [Fact]
        public void AddNewPerson_PizzaClient_AddsPizzaClient()
        {
            var testFactory = new TestFactory();

            var softDrinkDbManager = testFactory.GetSoftDrinkDbManager();

            var person = new PersonManager(testFactory);

            var personViewModel = new PersonViewModel { PersonName = "TEST", FoodItemType = 'S' };

            person.AddNewPerson(personViewModel);

            Assert.Single(softDrinkDbManager.GetPersons());

        }

        [Fact]
        public void AddNewPerson_SoftDrinkClient_AddsSoftDrinkClient()
        {
            var testFactory = new TestFactory();

            var pizzaDbManager = testFactory.GetPizzaDbManager();

            var person = new PersonManager(testFactory);

            var personVM = new PersonViewModel { PersonName = "TEST", FoodItemType = 'P' };

            person.AddNewPerson(personVM);

            Assert.Single(pizzaDbManager.GetPersons());

        }

    }
}
