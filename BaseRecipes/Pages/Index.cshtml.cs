using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Recipes_B_Logic;
using Recipes_B_Logic.Models;
using System;

namespace BaseRecipes.Pages
{
    public class IndexModel : PageModel
    {

        // array that corrispondes with the css classes used in the landing page.
        
        DataBase_Actions dbA = new DataBase_Actions();
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        /*api source is to broken to use.
         * the images are 404 coded. more then likely, the images are just not supported any more.
         */
        public List<string> GetRecipeImages()
        { 
           
            Random random = new Random(); 
            List<string> ThumbNails = new List<string>();
            Meal meal = new Meal();
            for (int i = 0; i < 26; i++)
            {
                int Id = random.Next(5009, 5237);
                meal = dbA.GetMealByID(Id);
                ThumbNails.Add(meal.strMealThumb);
            }
               
            return ThumbNails;
        }


        public void OnGet()
        {

        }
        
        // random number generator for general uses. Take min (n) and Max (x)
        public int randomNumberSelector(int n, int x)
        {
            Random r = new Random();
            return r.Next(n,x);
        }
    }
}