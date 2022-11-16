
using System;
using System.Net.Http;
using Recipes_B_Logic.Models;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Security.Principal;
using System.Web;

namespace Recipes_B_Logic
{
    /*
    Using httpclient to draw in data from api.
	*/
    public class API_Actions
    {

        /*
		Get request is Grabbing Meal plan from ID. 
		*/

        public DataBase_Actions DataBase = new DataBase_Actions();

        //Get API Call by Random
        public async Task PopulateDataBase(string RecipeName, int MaxRecipes)
        {
            
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(string.Format("https://recipesapi2.p.rapidapi.com/recipes/{0}?maxRecipes={1}", HttpUtility.HtmlAttributeEncode(RecipeName), MaxRecipes)),
                Headers =
                {
                    { "X-RapidAPI-Key", "9605ae55aamshc6b245b73128cf1p111fcejsn541111c3085c" },
                    { "X-RapidAPI-Host", "recipesapi2.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
           
                Datum meal1 = DeConstructJson(body);
                Debug.Print(meal1.name);
            }

        }
        public static Datum DeConstructJson(string body)
        {
            Root Meals = new Root();
            try
            {
                Meals = JsonConvert.DeserializeObject<Root>(body);



                Datum meal = Meals.data[0];

                return meal;

            }
            catch (Exception ex)
            {
                Debug.Print("We had an issue" + ex.Message.ToString());
                Datum? meal = null;
                return meal;
            }
        }
        // a method to prepare a string to be used as a uri for the http call.
        // recipe name N, Maximum amount of recipes = A for amount.
      
    }
}

        //OLD API CALLS Total Defunct

        /*
			Get API Call by meal category
		*/

        //public async Task PopulateDataBaseByCategory(string cat)
        //{

        //	var client = new HttpClient();
        //	var request = new HttpRequestMessage
        //	{
        //		Method = HttpMethod.Get,
        //		RequestUri = new Uri($"")
        //		Headers =
        //		{
        //			{ "X-RapidAPI-Key", "9605ae55aamshc6b245b73128cf1p111fcejsn541111c3085c" },
        //			{ "X-RapidAPI-Host", "themealdb.p.rapidapi.com" },
        //		},
        //	};
        //	using (var response = await client.SendAsync(request))
        //	{
        //		response.EnsureSuccessStatusCode();
        //		var body = await response.Content.ReadAsStringAsync();

        //		Meal meal1 = DeConstructJson(body);

        //		DataBase.StoreMeal(meal1);
        //	}

        //}

        ///*
        //	Get API Call by id
        //*/
        //public async Task PopulateDataBaseID(int Id)
        //      {
        //	//meals? meal = new meals();
        //	var client = new HttpClient();
        //	var request = new HttpRequestMessage
        //	{
        //		Method = HttpMethod.Get,
        //	
        //		Headers =
        //		{
        //			{ "X-RapidAPI-Key", "9605ae55aamshc6b245b73128cf1p111fcejsn541111c3085c" },
        //			{ "X-RapidAPI-Host", "themealdb.p.rapidapi.com" },
        //		},
        //	};
        //	using (var response = await client.SendAsync(request))
        //	{
        //		response.EnsureSuccessStatusCode();
        //		var body = await response.Content.ReadAsStringAsync();

        //		Meal meal1 = DeConstructJson(body);

        //		DataBase.StoreMeal(meal1);
        //	}

    
