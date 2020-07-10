using System.Collections.Generic;
using System.Threading.Tasks;

using Common;

namespace FrogRestaurant.Common.Application
{
   public interface ISoftDrinkService
    {
        Task<List<PersonViewModel>> GetPersonsAsync();
        void AddNewPerson(PersonViewModel personViewModel);
    }
}
