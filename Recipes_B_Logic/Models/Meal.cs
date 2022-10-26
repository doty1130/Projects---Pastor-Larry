using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Recipes_B_Logic.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Meal
    {
        public string? idMeal { get; set; }
        public string? strMeal { get; set; }
        public string? strDrinkAlternate { get; set; }
        public string? strCategory { get; set; }
        public string? strArea { get; set; }
        public string? strInstructions { get; set; }
        public string? strMealThumb { get; set; }
        public string? strYoutube { get; set; }
        public string? strIngredient1 { get; set; }
        public string? strIngredient2 { get; set; }
        public string? strIngredient3 { get; set; }
        public string? strIngredient4 { get; set; }
        public string? strIngredient5 { get; set; }
        public string? strIngredient6 { get; set; }
        public string? strIngredient7 { get; set; }
        public string? strIngredient8 { get; set; }
        public string? strIngredient9 { get; set; }
        public string? strIngredient10 { get; set; }
        public string? strIngredient11 { get; set; }
        public string? strIngredient12 { get; set; }
        public string? strIngredient13 { get; set; }
        public string? strIngredient14 { get; set; }
        public string? strIngredient15 { get; set; }
        public string? strIngredient16 { get; set; }
        public string? strIngredient17 { get; set; }
        public string? strIngredient18 { get; set; }
        public string? strIngredient19 { get; set; }
        public string? strIngredient20 { get; set; }
        public string? strMeasure1 { get; set; }
        public string? strMeasure2 { get; set; }
        public string? strMeasure3 { get; set; }
        public string? strMeasure4 { get; set; }
        public string? strMeasure5 { get; set; }
        public string? strMeasure6 { get; set; }
        public string? strMeasure7 { get; set; }
        public string? strMeasure8 { get; set; }
        public string? strMeasure9 { get; set; }
        public string? strMeasure10 { get; set; }
        public string? strMeasure11 { get; set; }
        public string? strMeasure12 { get; set; }
        public string? strMeasure13 { get; set; }
        public string? strMeasure14 { get; set; }
        public string? strMeasure15 { get; set; }
        public string? strMeasure16 { get; set; }
        public string? strMeasure17 { get; set; }
        public string? strMeasure18 { get; set; }
        public string? strMeasure19 { get; set; }
        public string? strMeasure20 { get; set; }
        public string? strSource { get; set; }
        public string? strImageSource { get; set; }
        public string? strCreativeCommonsConfirmed { get; set; }
        public string? dateModified { get; set; }
    }

    public class Root
    {
        public List<Meal> meals { get; set; }
    }


}


//////Json
////{
////    "meals": [
////      {
////        "idMeal": "52772",
////      "strMeal": "Teriyaki Chicken Casserole",
////      "strDrinkAlternate": null,
////      "strCategory": "Chicken",
////      "strArea": "Japanese",
////      "strInstructions": "Preheat oven to 350° F. Spray a 9x13-inch baking pan with non-stick spray.\r\nCombine soy sauce, ½ cup water, brown sugar, ginger and garlic in a small saucepan and cover. Bring to a boil over medium heat. Remove lid and cook for one minute once boiling.\r\nMeanwhile, stir together the corn starch and 2 tablespoons of water in a separate dish until smooth. Once sauce is boiling, add mixture to the saucepan and stir to combine. Cook until the sauce starts to thicken then remove from heat.\r\nPlace the chicken breasts in the prepared pan. Pour one cup of the sauce over top of chicken. Place chicken in oven and bake 35 minutes or until cooked through. Remove from oven and shred chicken in the dish using two forks.\r\n*Meanwhile, steam or cook the vegetables according to package directions.\r\nAdd the cooked vegetables and rice to the casserole dish with the chicken. Add most of the remaining sauce, reserving a bit to drizzle over the top when serving. Gently toss everything together in the casserole dish until combined. Return to oven and cook 15 minutes. Remove from oven and let stand 5 minutes before serving. Drizzle each serving with remaining sauce. Enjoy!",
////      "strMealThumb": "https://www.themealdb.com/images/media/meals/wvpsxx1468256321.jpg",
////      "strTags": "Meat,Casserole",
////      "strYoutube": "https://www.youtube.com/watch?v=4aZr5hZXP_s",
////      "strIngredient1": "soy sauce",
////      "strIngredient2": "water",
////      "strIngredient3": "brown sugar",
////      "strIngredient4": "ground ginger",
////      "strIngredient5": "minced garlic",
////      "strIngredient6": "cornstarch",
////      "strIngredient7": "chicken breasts",
////      "strIngredient8": "stir-fry vegetables",
////      "strIngredient9": "brown rice",
////      "strIngredient10": "",
////      "strIngredient11": "",
////      "strIngredient12": "",
////      "strIngredient13": "",
////      "strIngredient14": "",
////      "strIngredient15": "",
////      "strIngredient16": null,
////      "strIngredient17": null,
////      "strIngredient18": null,
////      "strIngredient19": null,
////      "strIngredient20": null,
////      "strMeasure1": "3/4 cup",
////      "strMeasure2": "1/2 cup",
////      "strMeasure3": "1/4 cup",
////      "strMeasure4": "1/2 teaspoon",
////      "strMeasure5": "1/2 teaspoon",
////      "strMeasure6": "4 Tablespoons",
////      "strMeasure7": "2",
////      "strMeasure8": "1 (12 oz.)",
////      "strMeasure9": "3 cups",
////      "strMeasure10": "",
////      "strMeasure11": "",
////      "strMeasure12": "",
////      "strMeasure13": "",
////      "strMeasure14": "",
////      "strMeasure15": "",
////      "strMeasure16": null,
////      "strMeasure17": null,
////      "strMeasure18": null,
////      "strMeasure19": null,
////      "strMeasure20": null,
////      "strSource": null,
////      "strImageSource": null,
////      "strCreativeCommonsConfirmed": null,
////      "dateModified": null
////      }
////  ]
