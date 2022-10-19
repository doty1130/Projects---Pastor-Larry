
using System;
using System.Net.Http;
using Recipes_B_Logic.Models;
using Newtonsoft.Json;


namespace Recipes_B_Logic
{
	
    //Attempting to determine what is the best api request techneic for this set up.
    //http client and RestSharp both have limitations.
	public  class API_Actions
    {
		//Full meal with Instructions. 
		Meal? DbModel = new Meal();
		Root2 DbModel2 = new Root2();

		// Get request is Grabbing Meal plan from ID. 

		public int Id = 52772;


		public async Task PopulateDataBase()
        {
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
				Console.WriteLine(body);
				DbModel = JsonConvert.DeserializeObject<Meal>(body);

				Console.WriteLine(DbModel);

				Console.WriteLine("struff");
			}

		}

		public async Task MealLookup()
		{
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://themealdb.p.rapidapi.com/filter.php?i=chicken_breast"),
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
				DbModel2 = JsonConvert.DeserializeObject<Root2>(body);

				Console.WriteLine("struff");
			}

		}


		/* ToDo with response body
		 * 
		 * Fill model. 
		 * Store Picture in file structure
		 * use model to fill database table entry,
		 * 
		 */


	}
}
