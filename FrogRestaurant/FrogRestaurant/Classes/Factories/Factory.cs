
using FrogRestaurant.Classes.Adaptors;

using PizzaDataAccess;
using PizzaDataAccess.Contracts;
using PizzaDataAccess.Database;

using SoftDrinkDataAccess;
using SoftDrinkDataAccess.Contracts;
using SoftDrinkDataAccess.Database;

namespace FrogRestaurant.Classes.Factories
{
    public interface IFactory
    {
        IPizzaDbManager GetPizzaDbManager();
        ISoftDrinkDbManager GetSoftDrinkDbManager();
        Adaptor GetAdaptor();
    }
    public class Factory : IFactory
    {
        private readonly PizzaDbContext _pizzaDbContext;
        private readonly SoftDrinkDbContext _softDrinkDbContext;
        public Factory(PizzaDbContext pizzaDbContext,
                        SoftDrinkDbContext softDrinkDbContext)
        {
            this._pizzaDbContext = pizzaDbContext;
            this._softDrinkDbContext = softDrinkDbContext;
        }

        public ISoftDrinkDbManager GetSoftDrinkDbManager()
        {
            ISoftDrinkDbManager softDrinkDbManger = new SoftDrinkDbManager(_softDrinkDbContext);

            return softDrinkDbManger;
        }

        public IPizzaDbManager GetPizzaDbManager()
        {
            IPizzaDbManager pizzaDbManger = new PizzaDbManager(_pizzaDbContext);
            return pizzaDbManger;
        }
        public Adaptor GetAdaptor()
        {
            return new Adaptor();
        }
    }
}
