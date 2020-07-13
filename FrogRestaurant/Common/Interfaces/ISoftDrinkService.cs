using System.Collections.Generic;
using System.Threading.Tasks;

using Common;
using Common.Models;

namespace FrogRestaurant.Common.Application
{
   public interface ISoftDrinkService
    {
        Task<List<PersonViewModel>> GetPersonsAsync();
        void AddNewPerson(PersonViewModel personViewModel);
    }
}
