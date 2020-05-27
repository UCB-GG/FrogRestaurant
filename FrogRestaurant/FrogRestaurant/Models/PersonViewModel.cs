using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FrogRestaurant.Models
{
    public class PersonViewModel
    {
        public string FoodItemDescription { get; set; }

        [DisplayName("Тип")]
        public char FoodItemType { get; set; }

        [DisplayName("Име")]
        public string PersonName { get; set; }
    }
}
