using Common.Interfaces;

using FrogRestaurant.Common.Application;

namespace WebApiService
{
    public class WebServiceFactory : IServiceFactory
    {
        public IPizzaService GetPizzaService()
        {
            throw new System.NotImplementedException();
        }

        public ISoftDrinkService GetSoftDrinkService()
        {
            throw new System.NotImplementedException();
        }
    }
}
