using FoodDataApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDataApp.Server.Services
{
    public interface IFoodDataService
    {
        Task<IEnumerable<Food>> GetAllFood();
        Task<Food> GetFoodDetails(int foodId);
        Task<Food> AddFood(Food food);
        Task UpdateFood(Food food);
        Task DeleteFood(int foodId);
    }
}
