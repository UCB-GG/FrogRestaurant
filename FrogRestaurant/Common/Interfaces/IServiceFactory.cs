using FrogRestaurant.Common.Application;

namespace Common.Interfaces
{
    public interface IServiceFactory
    {
        IPizzaService GetPizzaService();
        ISoftDrinkService GetSoftDrinkService();
    }
}
