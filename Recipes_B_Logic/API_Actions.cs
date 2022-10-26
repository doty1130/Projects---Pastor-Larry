
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
			
				DeConstructJson(body);


				
			}

		}


		public static void DeConstructJson(string body)
		{
			Root Meals = new Root();
			try
			{
				Meals = JsonConvert.DeserializeObject<Root>(body);

				Debug.Print("Is working");

				UploadToDateBase(Meals.meals[0]);

			}
			
			catch(Exception ex)
			{
				Debug.Print("We had an issue" + ex.Message.ToString());
			}
		}

		public static void UploadToDateBase(Meal meal)
		{ 
			 var dbConnection = "Data Source = (localdb)\ProjectModels; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"


			 using (dbConnection connection = factory.CreateConnection())
				
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
