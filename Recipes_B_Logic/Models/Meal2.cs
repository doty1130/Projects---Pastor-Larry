using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_B_Logic.Models
{
    public class Meal2
    {
        public string strMeal { get; set; }
        public string strMealThumb { get; set; }
        public string idMeal { get; set; }
    }

    public class Root2
    {
        public List<Meal2> meal2s { get; set; }
    }
}
