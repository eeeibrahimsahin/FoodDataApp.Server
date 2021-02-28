using FoodDataApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FoodDataApp.Server.Services
{
    public class FoodDataService : IFoodDataService
    {
        private readonly HttpClient httpClient;
        public FoodDataService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<Food> AddFood(Food food)
        {
            var foodJson =
               new StringContent(JsonSerializer.Serialize(food), Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("api/foods", foodJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<Food>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task DeleteFood(int foodId)
        {
            await httpClient.DeleteAsync($"api/foods/{foodId}");
        }

        public async Task<IEnumerable<Food>> GetAllFood()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Food>>
            (await httpClient.GetStreamAsync($"api/foods"), new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            });
        }

        public async Task<Food> GetFoodDetails(int foodId)
        {
            return await JsonSerializer.DeserializeAsync<Food>
               (await httpClient.GetStreamAsync($"api/foods/{foodId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task UpdateFood(Food food)
        {
            var foodJson =
                new StringContent(JsonSerializer.Serialize(food), Encoding.UTF8, "application/json");

            await httpClient.PutAsync("api/foods", foodJson);
        }
    }
}
