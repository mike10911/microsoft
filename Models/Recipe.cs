using System;
using Newtonsoft.Json;

namespace microsoft.Models
{
	public class Recipe
	{
		[JsonProperty(PropertyName = "id")]
		public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "isNutFree")]
        public bool IsNutFree { get; set; }

        [JsonProperty(PropertyName = "ingredient1")]
        public string? Ingredient1 { get; set; }

        [JsonProperty(PropertyName = "ingredient2")]
        public string? Ingredient2 { get; set; }

        [JsonProperty(PropertyName = "ingredient3")]
        public string? Ingredient3 { get; set; }


        public Recipe(string name, bool isNutFree, string? ingredient1, string? ingredient2, string? ingredient3)
        {
            Id = Convert.ToString(new Random().Next(1000));
            Name = name;
            IsNutFree = isNutFree;
            Ingredient1 = ingredient1;
            Ingredient2 = ingredient2;
            Ingredient3 = ingredient3;
        }
    }

}

