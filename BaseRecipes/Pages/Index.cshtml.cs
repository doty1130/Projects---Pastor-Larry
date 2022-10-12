using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace BaseRecipes.Pages
{
    public class IndexModel : PageModel
    {

        // array that corrispondes with the css classes used in the landing page.
        
        
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
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