
using System;
using System.Net.Http;
using Recipes_B_Logic.Models;
using Newtonsoft.Json;
using System.Diagnostics;



namespace Recipes_B_Logic
{
	/*
    Using httpclient to draw in data from api.
	*/
	public  class API_Actions
    {

		/*
		Get request is Grabbing Meal plan from ID. 
		*/
		
		public DataBase_Actions DataBase = new DataBase_Actions();

		//Get API Call by Random
		public async Task PopulateDataBaseAtRandom()
		{
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://themealdb.p.rapidapi.com/random.php"),
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

				DataBase.StoreMeal(meal1);
				Debug.Print(meal1.strMeal);
			}

		}

		/*
			Get API Call by meal category
		*/
		
		public async Task PopulateDataBaseByCategory(string cat)
		{
			
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri($"https://themealdb.p.rapidapi.com/filter.php?c={cat}"),
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

				DataBase.StoreMeal(meal1);
			}

		}

		/*
			Get API Call by id
		*/
		public async Task PopulateDataBaseID(int Id)
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

				DataBase.StoreMeal(meal1);
			}

		}

		/*
			Process the api data into the meal model
		*/

		public static Meal DeConstructJson(string body)
		{
			Root Meals = new Root();
			try
			{
				Meals = JsonConvert.DeserializeObject<Root>(body);

		

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
		 *
		 * 
		 */


	}
}
