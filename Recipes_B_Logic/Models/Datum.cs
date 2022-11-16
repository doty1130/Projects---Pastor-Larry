using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_B_Logic.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Datum
    {
        public string name { get; set; }
        public List<string> ingredients { get; set; }
        public List<string> instructions { get; set; }
        public Nutrients nutrients { get; set; }
        public List<object> tags { get; set; }
        public string servings { get; set; }
        public string image { get; set; }
        public Time time { get; set; }
    }

    public class Nutrients
    {
        public string protein { get; set; }
        public string carbohydrates { get; set; }

        [JsonProperty("dietary fiber")]
        public string dietaryfiber { get; set; }
        public string sugars { get; set; }
        public string fat { get; set; }

        [JsonProperty("saturated fat")]
        public string saturatedfat { get; set; }

        [JsonProperty("vitamin a iu")]
        public string vitaminaiu { get; set; }

        [JsonProperty("niacin equivalents")]
        public string niacinequivalents { get; set; }

        [JsonProperty("vitamin b6")]
        public string vitaminb6 { get; set; }

        [JsonProperty("vitamin c")]
        public string vitaminc { get; set; }
        public string folate { get; set; }
        public string calcium { get; set; }
        public string iron { get; set; }
        public string magnesium { get; set; }
        public string potassium { get; set; }
        public string sodium { get; set; }
        public string thiamin { get; set; }

        [JsonProperty("calories from fat")]
        public string caloriesfromfat { get; set; }
        public string cholesterol { get; set; }
    }

    public class Root
    {
        public List<Datum> data { get; set; }
    }

    public class Time
    {
        public string prepration_time { get; set; }
        public string cooking_time { get; set; }
        public string additional_time { get; set; }
        public string total { get; set; }
    }


}
