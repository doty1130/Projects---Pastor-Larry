
using System;
using System.Net.Http;
using Recipes_B_Logic.Models;
using Newtonsoft.Json;
using System.Diagnostics;



namespace Recipes_B_Logic
{
	
    //Attempting to determine what is the best api request techneic for this set up.
    //http client and RestSharp both have limitations.
	public  class API_Actions
    {
		

		// Get request is Grabbing Meal plan from ID. 

		public int Id = 52772;
		public DataBase_Actions DataBase = new DataBase_Actions();


		public async Task PopulateDataBase()
        {
			//meals? meal = new meals();
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri($"https://themealdb.p.rapidapi.com/lookup.php?i={Id}"),
				Headers =
				{
					{ "X-RapidAPI-Key", "9605ae55aamshc6b245b73128cf1p111fcejsn541111c3085c" },
					{ "X-RapidAPI-Host", "themealdb.p.rapidapi.com" },
				},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
			
				Meal meal1 = DeConstructJson(body);

				DataBase.DataBase_Manager(meal1);
			}

		}


		public static Meal DeConstructJson(string body)
		{
			Root Meals = new Root();
			try
			{
				Meals = JsonConvert.DeserializeObject<Root>(body);

				Debug.Print("Is working");

				Meal meal = Meals.meals[0];

				return meal;

			}
			catch(Exception ex)
			{
				Debug.Print("We had an issue" + ex.Message.ToString());
				Meal? meal = null;
				return meal;
			}
		}

	

		/* ToDo with response body
		 * 
		 * 
		 * Store Picture in file structure
		 * use model to fill database table entry,
		 * 
		 */


	}
}
