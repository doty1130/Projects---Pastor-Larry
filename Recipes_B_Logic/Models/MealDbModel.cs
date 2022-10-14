using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_B_Logic.Models
{
    public class MealDbModel
    { 
        public int idMeal { get; set; }
     
        public string? MealName { get; set; }
    
        public string? DrinkAlternet { get; set; }
   
        public string? Category { get; set; }
 
        public string? Area { get; set; }

        public string? Instructions { get; set; }
   
        public string? ImageName { get; set; }
     
        public string[]? Tags { get; set; }
      
        public string? YoutubeLink { get; set; }

        //In the Json format there are 20 seperate ingredents
        public string[]? Ingredents { get; set; }
        ////In the Json format there are 20 seperate Measurements
        public string[]? Measures { get; set; }
        
        public string? Source { get; set; }

        public string? CreativeCommonsConfirmed { get; set; }

        public DateTime DataModified { get; set; }
     
    }
}
