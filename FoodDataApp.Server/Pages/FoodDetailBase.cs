using FoodDataApp.Core;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDataApp.Server.Pages
{
    public class FoodDetailBase : ComponentBase
    {
        public IEnumerable<Food> Foods { get; set; }
        private List<Vitamin> Vitamins { get; set; }
        public Food Food { get; set; } = new Food();
        [Parameter]
        public string FoodId { get; set; }
        protected override Task OnInitializedAsync()
        {
            InitializeVitamins();
            InitializeFoods();

            Food = Foods.FirstOrDefault(f => f.FoodId == int.Parse(FoodId));
            return base.OnInitializedAsync();
        }
        private void InitializeVitamins()
        {
            Vitamins = new List<Vitamin>()
            {
                new Vitamin{VitaminId=1, Name="A"},
                new Vitamin{VitaminId=2, Name="B"},
                new Vitamin{VitaminId=3, Name="C"},
                new Vitamin{VitaminId=4, Name="D"},
            };
        }

        private void InitializeFoods()
        {
            var f1 = new Food
            {
                FoodId = 1,
                Name = "Apple",
                Calories = 95,
                Fat = 0.3,
                Cholestrol = 0,
                Sodium = 1.8,
                Potassium = 195,
                Carbohydrates = 25,
                Protein = 0.5,
                VitaminId = 1,
            };

            Foods = new List<Food>() { f1 };
        }

    }
}
